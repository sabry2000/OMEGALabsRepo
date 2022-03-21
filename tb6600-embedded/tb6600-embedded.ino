#include <Arduino.h>

const int PULSE_PIN = 2;
const int ENABLE_PIN = 3;
const int DIRECTION_PIN = 4;
const int PULSE_HALF_PERIOD_US = 50;

const String UP = "u";
const String DOWN = "d";
const String PULSES = "p";
const String INVALID_COMMAND_MSG = "Invalid Command";

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

  Serial.begin(9600); // opens serial port, sets data rate to 9600 bps
}

void loop() {
  // put your main code here, to run repeatedly:
  // send data only when you receive data:
  if (Serial.available() > 0) {
    // read the incoming byte:
    command = Serial.readString();

    int spaceIndex = command.indexOf(" ");
    if (spaceIndex == -1)
    {
      if (command == UP)
      {
        GoUp();
      }
      else if (command == DOWN)
      {
        GoDown();
      }
      else
      {
        SendInvalidCommandMsg();
      }
    }
    else
    {
      String cmd = command.substring(0, spaceIndex);
      String arg = command.substring(spaceIndex + 1);

      if (cmd == PULSES)
      {
        numberOfPulses = arg.toInt();
      }
      else
      {
        SendInvalidCommandMsg();
      }
    }
  }
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
}

void SendInvalidCommandMsg() {
  Serial.println(INVALID_COMMAND_MSG);
}
