#include <Arduino.h>

const int PULSE_PIN = 2;
const int ENABLE_PIN = 3;
const int DIRECTION_PIN = 4;
const int PULSE_HALF_PERIOD_US = 50;

const int CALIBRATE_PIN = 5;

const String UP = "u";
const String DOWN = "d";
const String PULSES = "p";
const String CALIBRATE = "c";

const String INVALID_COMMAND_MSG = "Invalid Command";
const String CALIBRATION_COMPLETE_MSG = "Calibration Complete";
const String COMMAND_EXECUTED_MSG = "Command Executed";

String command; // for incoming serial data
int numberOfPulses = 6400;


void setup() {
  // put your setup code here, to run once:
  pinMode(PULSE_PIN, OUTPUT);
  pinMode(ENABLE_PIN, OUTPUT);
  pinMode(DIRECTION_PIN, OUTPUT);

  digitalWrite(PULSE_PIN, LOW);
  digitalWrite(ENABLE_PIN, LOW);
  digitalWrite(DIRECTION_PIN, LOW);

  pinMode(CALIBRATE_PIN, INPUT);

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
      if (command.equals(UP))
        GoUp();
      else if (command.equals(DOWN))
        GoDown();
      else if (command.equals(CALIBRATE))
        Calibrate();
      else
        SendInvalidCommandMsg();
    }
    else
    {
      String cmd = command.substring(0, spaceIndex);
      String parameters = command.substring(spaceIndex + 1);

      if (cmd.equals(PULSES))
        SetNumberOfPulses(parameters);
      else
        SendInvalidCommandMsg();
    }
  }
}

void SetNumberOfPulses(String parameters) {
  numberOfPulses = parameters.toInt();
  char buff[100];
  sprintf(buff,"Set Number Of Pulses to: %d",numberOfPulses);
  Serial.println(buff);
}

void GoUp() {
  digitalWrite(DIRECTION_PIN, HIGH);
  for (int i = 0; i < numberOfPulses; i++) //Backward 5000 steps
  {
    digitalWrite(PULSE_PIN, HIGH);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
    digitalWrite(PULSE_PIN, LOW);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
  }
  SendCommandExecutedMsg();
}

void GoDown() {
  digitalWrite(DIRECTION_PIN, LOW);

  for (int i = 0; i < numberOfPulses; i++) //Backward 5000 steps
  {
    digitalWrite(PULSE_PIN, HIGH);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
    digitalWrite(PULSE_PIN, LOW);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
  }
  SendCommandExecutedMsg();
}

void Calibrate() {
  while (digitalRead(CALIBRATE_PIN) == LOW) {
    GoUp();
  }
  Serial.println(CALIBRATION_COMPLETE_MSG);
}

void SendCommandExecutedMsg() {
  Serial.println(COMMAND_EXECUTED_MSG);
}

void SendInvalidCommandMsg() {
  Serial.println(INVALID_COMMAND_MSG);
}
