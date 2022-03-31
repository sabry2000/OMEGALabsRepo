#include <Arduino.h>
#include <LiquidCrystal.h>


#include "pinconfig.h"
#include "TB6600.h"

const char UP = 'u';
const char DOWN = 'd';
const char PULSES = 'p';
const char CALIBRATE = 'c';


const String INVALID_COMMAND_MSG = "Invalid Command";
const String CALIBRATION_COMPLETE_MSG = "Calibration Complete";
const String COMMAND_EXECUTED_MSG = "Command Executed";
const String POSITION_MSG_FORMAT = "Current Position: %.3d";

String command; // for incoming serial data

TB6600 tb6600(PULSE_PIN, ENABLE_PIN, DIRECTION_PIN, CALIBRATE_PIN);
LiquidCrystal lcd(LCD_RESET_PIN, LCD_ENABLE_PIN, LCD_D4_PIN, LCD_D5_PIN, LCD_D6_PIN, LCD_D7_PIN);

void setup() {
  // put your setup code here, to run once:
  pinMode(UP_BUTTON, INPUT_PULLUP);
  pinMode(DOWN_BUTTON, INPUT_PULLUP);
  attachInterrupt(digitalPinToInterrupt(UP_BUTTON), [](){tb6600.GoUp();}, LOW);
  attachInterrupt(digitalPinToInterrupt(DOWN_BUTTON), [](){tb6600.GoUp();}, LOW);

  // set up the LCD's number of columns and rows:
  lcd.begin(16, 2);
  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
}

void loop() {
  // put your main code here, to run repeatedly:
  // send data only when you receive data:
  if (Serial.available() > 0) {
    // read the incoming byte:
    command = Serial.readString();
    command.remove(command.length()-1);

    int spaceIndex = command.indexOf(" ");
    if (spaceIndex == -1)
    {
      if (command.charAt(0) == UP){
        tb6600.GoUp();
      }else if (command.charAt(0) == DOWN){
        tb6600.GoDown();
      }else if (command.charAt(0) == CALIBRATE){
        tb6600.Calibrate();
      }else{
        Display(INVALID_COMMAND_MSG);
      }
    }
    else
    {
      String cmd = command.substring(0, spaceIndex);
      String parameters = command.substring(spaceIndex + 1);

      if (cmd.charAt(0) == PULSES)
        SetNumberOfPulses(parameters);
      else
        Display(INVALID_COMMAND_MSG);
    }
  }
}

void SetNumberOfPulses(String parameters) {
  int numberOfPulses = parameters.toInt();
  numberOfPulses = tb6600.SetNumberOfPulses(numberOfPulses);
  char buff[100];
  sprintf(buff,"Set Number Of Pulses to: %d",numberOfPulses);
  Display(buff);
}

void GoUp() {
  tb6600.GoUp();
  Display(COMMAND_EXECUTED_MSG);
}

void GoDown() {
  tb6600.GoDown();
  Display(COMMAND_EXECUTED_MSG);
}

void Calibrate() {
  tb6600.Calibrate();
  Display(CALIBRATION_COMPLETE_MSG);
}

void Display(const String& msg){
  Serial.println(msg);
}
