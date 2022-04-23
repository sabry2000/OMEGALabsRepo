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
const char LOCATION_MSG_FORMAT[25] = "Current Location: %.3d";
const char PULSES_MSG_FORMAT[50] = "Set Number Of Pulses to: %.3d";

String command; // for incoming serial data
char msg[100];
double location;

TB6600 tb6600(PULSE_PIN, ENABLE_PIN, DIRECTION_PIN, CALIBRATE_PIN);
LiquidCrystal lcd(LCD_RESET_PIN, LCD_ENABLE_PIN, LCD_D4_PIN, LCD_D5_PIN, LCD_D6_PIN, LCD_D7_PIN);

String GetLocationMsg(){
  location = tb6600.GetCurrentLocation();
  sprintf(msg, LOCATION_MSG_FORMAT, location);
  return msg;
}

void IRAM_ATTR GoUp(){
  tb6600.GoUp();
  
  location = tb6600.GetCurrentLocation();
  sprintf(msg, LOCATION_MSG_FORMAT, location);
  Serial.println(msg);

  lcd.setCursor(0,1);
  lcd.print(location);
}

void IRAM_ATTR GoDown(){
  tb6600.GoDown();
  
  location = tb6600.GetCurrentLocation();
  sprintf(msg, LOCATION_MSG_FORMAT, location);
  Serial.println(msg);
  
  lcd.setCursor(0,1);
  lcd.print(location);
}

void IRAM_ATTR Calibrate(){
  tb6600.Calibrate();

  location = tb6600.GetCurrentLocation();
  Serial.println(CALIBRATION_COMPLETE_MSG);
  lcd.setCursor(0,1);
  lcd.print(location);
}

void SetNumberOfPulses(String parameters) {
  int numberOfPulses = parameters.toInt();
  numberOfPulses = tb6600.SetNumberOfPulses(numberOfPulses);
  sprintf(msg, PULSES_MSG_FORMAT, numberOfPulses);
  Serial.println(msg);
}

void AttachInterrupts(){
  attachInterrupt(UP_BUTTON, GoUp, LOW);
  attachInterrupt(DOWN_BUTTON, GoDown, LOW);
  attachInterrupt(CALIBRATE_BUTTON, Calibrate, LOW);
}

void DetachInterrupts(){
  detachInterrupt(UP_BUTTON);
  detachInterrupt(DOWN_BUTTON);
  detachInterrupt(CALIBRATE_BUTTON);
}

void setup() {
  // put your setup code here, to run once:
  pinMode(UP_BUTTON, INPUT_PULLUP);
  pinMode(DOWN_BUTTON, INPUT_PULLUP);
  pinMode(CALIBRATE_BUTTON, INPUT_PULLUP);

  AttachInterrupts();

  // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);
  lcd.setCursor(0,0);
  lcd.print(LOCATION_MSG_HEADER);

  location = tb6600.GetCurrentLocation();
  lcd.setCursor(0,1);
  lcd.print(location);
  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
}

void loop() {
  // put your main code here, to run repeatedly:
  // send data only when you receive data:
  if (Serial.available() > 0) {
    DetachInterrupts();
    // read the incoming byte:
    command = Serial.readString();
    command.remove(command.length()-1);

    int spaceIndex = command.indexOf(" ");
    if (spaceIndex == -1)
    {
      if (command.charAt(0) == UP){
        GoUp();
      
      }else if (command.charAt(0) == DOWN){
        GoDown();   
      
      }else if (command.charAt(0) == CALIBRATE){
        Calibrate();
              
      }else if (command.charAt(0) == LOCATION){
        Serial.println(GetLocationMsg());
      
      }else{
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
    
    lcd.autoscroll();
  }
}
