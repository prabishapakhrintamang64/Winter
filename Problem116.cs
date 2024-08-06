using System;
namespace Application
{
    public class Problem116
    {
        public static void solution()
        {
            DiseaseA diseaseA= new DiseaseA("Cancer");
            DiseaseA diseaseA1= new DiseaseA("Allergy");
            DiseaseA[] ff= new DiseaseA[]{diseaseA, diseaseA1};

            Doctor doctor= new HumanDoctor("DR Jhatka","DR Kasuda");
            Hospital<DiseaseA, Doctor> obj = new Hospital<DiseaseA, Doctor>("Makwanpur" , ff, doctor);


            DiseaseB diseaseB= new DiseaseB("Chickenpox");
            DiseaseB diseaseB1= new DiseaseB("Birdflu");
            DiseaseB[] ufff= new DiseaseB[]{diseaseB, diseaseB1};

            Doctor doctor1= new AnimalDoctor("DR billa","DR Killa");
            Hospital<DiseaseB, Doctor> obj1 = new Hospital<DiseaseB, Doctor>("Animal center", ufff, doctor);
            obj.ShowHospital();
            obj1.ShowHospital();
        }

        public class DiseaseA
        {
            public string DiseaseName;
            public DiseaseA( string diseasename )
            {
               DiseaseName=diseasename;
            }
            public void ShowDiseaseA()
            {
                Console.WriteLine($"DiseaseName:{DiseaseName}");
            } 
        }
             public class DiseaseB
        {
            public string DiseaseName;
            public DiseaseB( string diseasename )
            {
               DiseaseName=diseasename;
            }
            public void ShowDiseaseB()
            {
                Console.WriteLine($"DiseaseName:{DiseaseName}");
            } 
        }

        class Patient<T>
        {
            public string PatientName;
            public T[] Diseases;
            public Patient(string patientname, T[] diseases)
            {
                PatientName= patientname;
                Diseases= diseases;
            }
            public void ShowPatient()
            {
                Console.WriteLine($"PatientName:{PatientName}");
                Console.WriteLine("Diseases:");
                foreach(var diseases in Diseases)
                {
                    if(diseases is DiseaseA diseasea)
                    {
                        diseasea.ShowDiseaseA();
                    }
                    else if(diseases is DiseaseB diseaseB)
                    {
                        diseaseB.ShowDiseaseB();
                    }
                }
            }
        }
         class Doctor
         {
            public string DoctorName;
            public Doctor(string doctorname)
            {
                DoctorName= doctorname;
            }
            public void ShowDoctor()
            {
                Console.WriteLine($"DoctorName:{DoctorName}");
            }
         }
         class HumanDoctor: Doctor
         {
            public string HumanDoctorName;
            public HumanDoctor(string doctorname, string humandoctorname):base(doctorname)
            {
                HumanDoctorName=humandoctorname;
            }
            public void ShowHD()
            {
                Console.WriteLine($"HumanDoctorName:{HumanDoctorName}");
            }

         }
         class AnimalDoctor: Doctor
         {
            public string AnimalDoctorName;
            public AnimalDoctor(string doctorname, string animaldoctorname): base(doctorname)
            {
                AnimalDoctorName= animaldoctorname;
            }
            public void ShowAD()
            {
                Console.WriteLine($"AnimalDoctorName:{AnimalDoctorName}");
            }

         }
         class Hospital<T, P>
         {
            public string HospitalName;
            public T[] Patients;
            public P Doctors;
            public Hospital( string hospitalname, T[] patients, P doctors)
            {
                HospitalName= hospitalname;
                Patients= patients;
                Doctors= doctors;
            }
            public void ShowHospital()
            {
                Console.WriteLine($"HospitalRate:{HospitalName}");
                foreach(var patient in Patients)
                {
                    if (patient is DiseaseA diseasea)
                    {
                        diseasea.ShowDiseaseA();
                    }
                    else if (patient is DiseaseB diseaseb)
                    {
                        diseaseb.ShowDiseaseB();
                    }
                }
                
                    if (Doctors is HumanDoctor human)
                    {
                        human.ShowHD();
                    }
                    else if (Doctors is AnimalDoctor animal)
                    {
                        animal.ShowAD();
                    }
            }
        }
    }
}
