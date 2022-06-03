#pragma once

class TB6600 {
  private:
    static const int MAX_INT = 0x7FFF;
  private:
    static const int PULSE_HALF_PERIOD_US = 50;
    static constexpr double INCHES_PER_REVOLUTION = 0.1875;
    static const int PULSES_PER_REVOLUTION = 6400;
    static const int MAXIMUM_HEIGHT = 12;
    int m_numberOfPulses = 6400;

  private:
    int m_pulsePin;
    int m_enablePin;
    int m_directionPin;
    int m_calibrationPin;

  private:
    double m_location;

  public:
    TB6600(const int& pulsePin, const int& enablePin, const int& directionPin, const int& calibrationPin);

  private:
    bool IsAtZero();

  public:
    void GoUp();
    void GoDown();
    void Calibrate();
    int SetNumberOfPulses(const int& numberOfPulses);
    double GetCurrentLocation();
};
