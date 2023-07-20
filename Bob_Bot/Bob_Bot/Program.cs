using Bob_Bot;

Console.WriteLine("********************************Medical Bot********************************\n");
Console.WriteLine("Hi, I'm Bob. I'm here to help you in your medication.\n");
Console.WriteLine("Enter your (patient) details:");
    
Patient patient = new Patient();
MedicalBot medicalBot = new MedicalBot();   

string errorMessage = string.Empty;

Console.Write("Enter Patient Name :");
while(! patient.SetName(Console.ReadLine(), out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.Write("Enter Patient Name Again:");
}


Console.Write("Enter Patient Age :");
do
{
    int age;
    while (!int.TryParse(Console.ReadLine(), out age))
    {
        Console.WriteLine("age must be integer value");
        Console.Write("Enter Patient Age Again:");
    }

    if(! patient.SetAge(age ,out errorMessage))
    {
        Console.WriteLine(errorMessage);
        Console.Write("Enter Patient Age Again:");
    }
} while (patient.GetAge() == 0);


Console.Write("Enter Patient Gender :");
while(! patient.SetGender(Console.ReadLine(),out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.WriteLine("Enter Patient Gender Again");
}


Console.WriteLine("do you suffer from diabetes?\n(Yes/No) :");
while(! patient.SetDiabetesSuffer(Console.ReadLine(),out errorMessage))
{
    Console.WriteLine(errorMessage);
}

Console.WriteLine();
Console.WriteLine($"Welcome ,{patient.GetName()}");
Console.WriteLine($"your Information ::");
Console.WriteLine(patient);

Console.WriteLine();
Console.WriteLine(@"Which of the following symptoms do you have:
                        S1. Headache    
                        S2. Skin rashes
                        S3. Dizziness
Enter the symptom code from above list (S1, S2 or S3): S2");

while(! patient.SetSymptomCode(Console.ReadLine() ,out errorMessage))
{
    Console.WriteLine(errorMessage);
    Console.WriteLine("Enter the symptom code again");
}

medicalBot.PrescribeMedication(patient);
Console.WriteLine() ;
Console.WriteLine("Your prescription based on your age, symptoms and medical history:");
Console.WriteLine(patient.Prescription);
Console.WriteLine("\nThank you for coming.");
Console.ReadKey();

