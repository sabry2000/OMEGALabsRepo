const int PULSE_PIN = 2;
const int ENABLE_PIN = 3;
const int DIRECTION_PIN = 4;
const int PULSE_PERIOD_US = 50;
const int NUMBER_OF_PULSES = 3200;

int incomingByte = 0; // for incoming serial data

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
    incomingByte = Serial.read();

    if (incomingByte == 'u')
    {
      GoUp();
    }
    else if (incomingByte == 'd')
    {
      GoDown();
    }
  }
}

void GoUp() {
  for (int i = 0; i < NUMBER_OF_PULSES; i++) //Backward 5000 steps
  {
    digitalWrite(DIRECTION_PIN, HIGH);
    digitalWrite(PULSE_PIN, HIGH);
    delayMicroseconds(PULSE_PERIOD_US);
    digitalWrite(PULSE_PIN, LOW);
    delayMicroseconds(PULSE_PERIOD_US);
  }
}

void GoDown() {
  Serial.println("DOWN");
  for (int i = 0; i < NUMBER_OF_PULSES; i++) //Backward 5000 steps
  {
    digitalWrite(DIRECTION_PIN, LOW);
    digitalWrite(PULSE_PIN, HIGH);
    delayMicroseconds(PULSE_PERIOD_US);
    digitalWrite(PULSE_PIN, LOW);
    delayMicroseconds(PULSE_PERIOD_US);
  }
}
