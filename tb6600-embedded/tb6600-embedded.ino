#include <Arduino.h>
#include <LiquidCrystal.h>

#include "pinconfig.h"
#include "TB6600.h"

const char UP = 'u';
const char DOWN = 'd';
const char PULSES = 'p';
const char CALIBRATE = 'c';
const char LOCATION = 'l';

const String INVALID_COMMAND_MSG = "Invalid Command";
const String CALIBRATION_COMPLETE_MSG = "Calibration Complete";
const String COMMAND_EXECUTED_MSG = "Command Executed";

const String UP_COMMAND_MSG = "UP Command Executed";
const String DOWN_COMMAND_MSG = "DOWN Command Executed";

const String LOCATION_MSG_HEADER = "Current Location: ";
const String LOCATION_MSG_FOOTER = " (Inches)";
const char LOCATION_MSG_FORMAT[25] = "Current Location: %.3d (Inches)";

const String PULSES_MSG_HEADER = "Set Number Of Pulses to: ";
const char PULSES_MSG_FORMAT[50] = "Set Number Of Pulses to: %.3d";

const int decimalPlaces = 6;
const int locationLength = 10;

String command; // for incoming serial data
String msg;
double location;
char cLocation[10];

TB6600 tb6600(PULSE_PIN, ENABLE_PIN, DIRECTION_PIN, CALIBRATE_PIN);
LiquidCrystal lcd(LCD_RESET_PIN, LCD_ENABLE_PIN, LCD_D4_PIN, LCD_D5_PIN, LCD_D6_PIN, LCD_D7_PIN);

void PrintLocationMsg() {
  location = tb6600.GetCurrentLocation();
  dtostrf(location, locationLength, decimalPlaces, cLocation);
  msg = LOCATION_MSG_HEADER + (String)cLocation + LOCATION_MSG_FOOTER;
  Serial.println(msg);
}

void GoUp() {
  digitalWrite(LED, HIGH);
  tb6600.GoUp();

  PrintLocationMsg();

  lcd.setCursor(0, 1);
  lcd.print(location);
  digitalWrite(LED, LOW);
}

void GoDown() {
  digitalWrite(LED, HIGH);
  tb6600.GoDown();

  PrintLocationMsg();

  lcd.setCursor(0, 1);
  lcd.print(location);
  digitalWrite(LED, LOW);
}

void Calibrate() {
  digitalWrite(LED, HIGH);
  tb6600.Calibrate();

  location = tb6600.GetCurrentLocation();
  Serial.println(CALIBRATION_COMPLETE_MSG);
  
  lcd.setCursor(0, 1);
  lcd.print(location);
  digitalWrite(LED, LOW);
}

void SetNumberOfPulses(String parameters) {
  int numberOfPulses = parameters.toInt();
  numberOfPulses = tb6600.SetNumberOfPulses(numberOfPulses);
  
  msg = PULSES_MSG_HEADER + (String)numberOfPulses;
  //sprintf(msg, PULSES_MSG_FORMAT, numberOfPulses);
  Serial.println(msg);
}

void AttachInterrupts() {
  attachInterrupt(UP_BUTTON, GoUp, LOW);
  attachInterrupt(DOWN_BUTTON, GoDown, LOW);
  attachInterrupt(CALIBRATE_BUTTON, Calibrate, LOW);
}

void DetachInterrupts() {
  detachInterrupt(UP_BUTTON);
  detachInterrupt(DOWN_BUTTON);
  detachInterrupt(CALIBRATE_BUTTON);
}

void setup() {
  // put your setup code here, to run once:
  pinMode(UP_BUTTON, INPUT);
  pinMode(DOWN_BUTTON, INPUT);
  pinMode(CALIBRATE_BUTTON, INPUT);

  pinMode(LED, OUTPUT);

  //AttachInterrupts();

  // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);
  lcd.setCursor(0, 0);
  lcd.print(LOCATION_MSG_HEADER);

  location = tb6600.GetCurrentLocation();
  lcd.setCursor(0, 1);
  lcd.print(location);
  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
}

void loop() {

  //  delay(500);
  //  digitalWrite(LED,HIGH);

  if (digitalRead(UP_BUTTON) == LOW) {
    tb6600.SetDefaultPulses();
    GoUp();
  }
  if (digitalRead(DOWN_BUTTON) == LOW) {
    tb6600.SetDefaultPulses();
    GoDown();
  }
  if (digitalRead(CALIBRATE_BUTTON) == LOW) {
    tb6600.SetDefaultPulses();
    Calibrate();
  }

  // put your main code here, to run repeatedly:
  // send data only when you receive data:
  if (Serial.available() > 0) {
    //DetachInterrupts();
    // read the incoming byte:
    command = Serial.readString();
    command.remove(command.length() - 1);

    int spaceIndex = command.indexOf(" ");
    if (spaceIndex == -1)
    {
      if (command.charAt(0) == UP) {
        GoUp();

      } else if (command.charAt(0) == DOWN) {
        GoDown();

      } else if (command.charAt(0) == CALIBRATE) {
        Calibrate();

      } else if (command.charAt(0) == LOCATION) {
        PrintLocationMsg();

      } else {
        Serial.println(INVALID_COMMAND_MSG);
      }
    }
    else
    {
      String cmd = command.substring(0, spaceIndex);
      String parameters = command.substring(spaceIndex + 1);

      if (cmd.charAt(0) == PULSES)
        SetNumberOfPulses(parameters);
      else
        Serial.println(INVALID_COMMAND_MSG);
    }
    //AttachInterrupts();
  }

  //  delay(500);
  //  digitalWrite(LED,LOW);
}
