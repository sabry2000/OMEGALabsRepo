const int PULSE_PIN = 2;
const int ENABLE_PIN = 3;
const int DIRECTION_PIN = 4;
const int PULSE_HALF_PERIOD_US = 50;

const char UP_COMMAND = 'u';
const char DOWN_COMMAND = 'd';
const char SET_NUMBER_OF_PULSES_COMMAND = 'p';


int NUMBER_OF_PULSES = 6400;

String commandString; // for incoming serial data
char command;
String commandArgument;

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
    commandString = Serial.readString();
    command = commandString.charAt(0);
    
    int spaceIndex = commandString.indexOf(' ');
    if (spaceIndex != -1){
        commandArgument = commandString.substring(spaceIndex);
    }

    switch (command) {
      case UP_COMMAND:
        GoUp();
        break;
      case DOWN_COMMAND:
        GoUp();
        break;
      case SET_NUMBER_OF_PULSES_COMMAND:
//        String numberOfPulsesString = Serial.readString();
//        
//        for (int i = numberOfPulsesString.length() - 1; i >= 0; i--){
//          char character = numberOfPulsesString.charAt(i);
//          if (character == ' ')
//            numberOfPulsesString.remove(i);
//        }
//        int numberOfPulses =  numberOfPulsesString.parseInt(); 

        int numberOfPulses = commandArgument.toInt();
        SetNumberOfPulses(numberOfPulses);
        break;
      default:
      // clear input buffer;
        while (Serial.read() >= 0)
          ; // do nothing
        break;
    }
  }
}

void GoUp() {
  digitalWrite(DIRECTION_PIN, HIGH);
  
  for (int i = 0; i < NUMBER_OF_PULSES; i++)
  {
    digitalWrite(PULSE_PIN, HIGH);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
    digitalWrite(PULSE_PIN, LOW);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
  }
}

void GoDown() {
  digitalWrite(DIRECTION_PIN, LOW);
  
  for (int i = 0; i < NUMBER_OF_PULSES; i++)
  {
    digitalWrite(PULSE_PIN, HIGH);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
    digitalWrite(PULSE_PIN, LOW);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
  }
}

void SetNumberOfPulses(int numberOfPulses){
  NUMBER_OF_PULSES = numberOfPulses;
}
