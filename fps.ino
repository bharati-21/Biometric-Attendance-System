#include "FPS_GT511C3.h"
#include "SoftwareSerial.h"

FPS_GT511C3 fps(8, 7); //Arduino RX TX
void setup()
{
  Serial.begin(9600);
  //fps.UseSerialDebug = true;
  fps.Open();

  task();
}

void task()
{
  char i = '0';
  while (true)
  {
    i = Serial.read();
    // Serial.println(i);
    if (i != '0')
    {
      break;
    }
  }


  if (i == '1')
  {
    fps.SetLED(true);
    Enroll();
    fps.SetLED(false);

  }
  if (i == '2')
  {
    fps.SetLED(true);
    Verify();

    fps.SetLED(false);
  }
  if (i == '3')
  {

    delay(2000);
    int val = Serial.parseInt();
    if (fps.DeleteID(val) == true)
    {
      Serial.println("Deleted");
    }
    else
    {
      Serial.println("Invalid ID");
    }
    //delay(2000);
  }
  if (i == '4')
  {

    if(fps.DeleteAll()==true)
     Serial.println("Deleted alll");
   else
    Serial.println("Deleted None");
    
    //delay(2000);
  }
  task();

}



void loop()
{
  delay(100);
}


void Verify()
{
  Serial.println("Press` finger");
  while (fps.IsPressFinger() == false) delay(100);

  fps.CaptureFinger(false);
  int id = fps.Identify1_N();
  if (id < 200)
  {
    Serial.print("Verified ID = ");
    Serial.println(id);
  }
  else
  {
    Serial.println("Finger not found");
  }



}

void Enroll()
{
  int enrollid = 0;             // find open enroll id
  bool okid = true;
  while (okid == true)
  {
    okid = fps.CheckEnrolled(enrollid);
    if (okid == true) enrollid++;
  }
  fps.EnrollStart(enrollid);   // enroll


  Serial.print("Press finger to Enroll #");

  Serial.println(enrollid);
  while (fps.IsPressFinger() == false) delay(100);


  bool bret = fps.CaptureFinger(true);
  int iret = 0;
  if (bret != false)
  {
    delay(1000);
    Serial.println("Remove finger");

    fps.Enroll1();
    while (fps.IsPressFinger() == true) delay(100);
    Serial.println("Press same finger again");

    while (fps.IsPressFinger() == false) delay(100);

    bret = fps.CaptureFinger(true);
    if (bret != false)
    {
      delay(1000);
      Serial.println("Remove finger");

      fps.Enroll2();
      while (fps.IsPressFinger() == true) delay(100);
      Serial.println("Press same finger yet again");

      while (fps.IsPressFinger() == false) delay(100);
      bret = fps.CaptureFinger(true);
      if (bret != false)
      {
        delay(1000);
        Serial.println("Remove finger");

        iret = fps.Enroll3();
        if (iret == 0)
        {
          delay(1000);
          Serial.println("Enrolling Successfull");
          Serial.print("ID = ");
          Serial.println(enrollid);
        }
        else
        {
          Serial.print("Enrolling Failed with error code:");
          Serial.println(iret);
        }
      }
      else Serial.println("Failed to capture third finger");
    }
    else Serial.println("Failed to capture second finger");
  }
  else Serial.println("Failed to capture first finger");
}
