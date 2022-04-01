#include <Arduino.h>
#include "TB6600.h"

TB6600::TB6600(const int& pulsePin, const int& enablePin, const int& directionPin, const int& calibrationPin){
  m_pulsePin = pulsePin;
  m_enablePin = enablePin;
  m_directionPin = directionPin;
  m_calibrationPin = calibrationPin;

  pinMode(m_calibrationPin, INPUT_PULLUP);

  pinMode(m_pulsePin, OUTPUT);
  pinMode(m_enablePin, OUTPUT);
  pinMode(m_directionPin, OUTPUT);

  digitalWrite(m_pulsePin, LOW);
  digitalWrite(m_enablePin, LOW);
  digitalWrite(m_directionPin, LOW);

  Calibrate();
}

double TB6600::GetCurrentLocation(){
  return m_location;
}

bool TB6600::IsAtZero() {
  return (digitalRead(m_calibrationPin) == HIGH);
}

void TB6600::GoUp() {
  digitalWrite(m_directionPin, HIGH);
  
  int i;
  for (i = 0; (i < m_numberOfPulses) && (m_location + 1/PULSES_PER_REVOLUTION < MAXIMUM_HEIGHT); i++)
  {
    digitalWrite(m_pulsePin, HIGH);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
    digitalWrite(m_pulsePin, LOW);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
  }
  
  m_location += (INCHES_PER_REVOLUTION * i/ PULSES_PER_REVOLUTION);
}

void TB6600::GoDown() {
  digitalWrite(m_directionPin, LOW);
  
  int i;
  for (i = 0; (i < m_numberOfPulses) && (!IsAtZero()); i++)
  {
    digitalWrite(m_pulsePin, HIGH);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
    digitalWrite(m_pulsePin, LOW);
    delayMicroseconds(PULSE_HALF_PERIOD_US);
  }
  
  m_location -= (INCHES_PER_REVOLUTION * i/ PULSES_PER_REVOLUTION);
  
}

void TB6600::Calibrate() {
  while (!IsAtZero()) {
    GoDown();
  }
  m_location = 0;
}

//add logic to check size for number of pulses validity
int TB6600::SetNumberOfPulses(const int& numberOfPulses) {
  m_numberOfPulses = numberOfPulses;
  return m_numberOfPulses; 
}
