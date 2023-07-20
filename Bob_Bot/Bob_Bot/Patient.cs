using System;

namespace Bob_Bot;

class Patient
{
    private string? name;
    private int age;
    private string? gender;
    private string? symptomCode;
    private bool suffersDiabetes;

    public string? Prescription { get; set; }

    public string? GetName()
    {
        return name;
    }
    public bool SetName(string? name ,out string errorMessage)
    {
        errorMessage = string.Empty;

        if(string.IsNullOrEmpty(name))
        {
            errorMessage = "patient name can't be empty";
            return false;
        }
        if(name.Length < 2)
        {
            errorMessage = "patient name length can't be less than 2 characters";
            return false;
        }
        if (name.Length > 100)
        {
            errorMessage = "patient name length can't be more than 100 characters";
            return false;
        }

        this.name = name;
        return true;
    }


    public int GetAge()
    {
        return age;
    }
    public bool SetAge(int age, out string errorMessage)
    {
        errorMessage = string.Empty;
        if(age <= 0)
        {
            errorMessage = "age can't be negative or zero!!";
            return false;
        }
        if(age > 100)
        {
            errorMessage = "age can't be more than 100";
            return false;
        }

        this.age = age;
        return true;
    }


    public string GetGender()
    {
        return gender;
    }
    public bool SetGender(string? gender , out string errorMessage)
    {
        errorMessage = string.Empty;

        bool isValid = gender.Equals("male", StringComparison.OrdinalIgnoreCase) ||
                       gender.Equals("female", StringComparison.OrdinalIgnoreCase) ||
                       gender.Equals("other", StringComparison.OrdinalIgnoreCase);

        if(!isValid)
        {
            errorMessage = "gender can be only male or female or other";
            return false;
        }

        this.gender = gender;
        return true;
    }


    public bool GetDiabetesSuffer()
    {
        return suffersDiabetes;
    }
    public bool SetDiabetesSuffer(string? diabetesSuffer ,out string errorMessage)
    {
        errorMessage= string.Empty;

        if (string.IsNullOrEmpty(diabetesSuffer))
        {
            errorMessage = "suffering from diabetes can't be empty.\nEnter Yes or No";
            return false;
        }

        bool isValid = diabetesSuffer.Equals("yes", StringComparison.OrdinalIgnoreCase) ||
                        diabetesSuffer.Equals("no", StringComparison.OrdinalIgnoreCase);

        if(! isValid)
        {
            errorMessage = "suffering from diabetes can't be empty.\nEnter Yes or No";
            return false;
        }

        if(diabetesSuffer.Equals("yes", StringComparison.OrdinalIgnoreCase))
        {
            this.suffersDiabetes = true;
        }
        else
        {
            this.suffersDiabetes = false;
        }
        return true;
    }


    public bool SetSymptomCode(string? symptomCode, out string errorMessage)
    {
        errorMessage = string.Empty;

        if (string.IsNullOrEmpty(symptomCode))
        {
            errorMessage = "symptomCode can't be empty";
            return false;
        }

        bool isValid = symptomCode.Equals("S1", StringComparison.OrdinalIgnoreCase) ||
                       symptomCode.Equals("S2", StringComparison.OrdinalIgnoreCase) ||
                       symptomCode.Equals("S3", StringComparison.OrdinalIgnoreCase);

        if(!isValid)
        {
            errorMessage = "symptomCode can only be s1 or s2 or s3";
            return false;
        }

        this.symptomCode = symptomCode;
        return true;
    }
    public string GetSymptomCode()
    {
        if (string.IsNullOrEmpty(symptomCode))
        {  
            return "Unkown";
        }
        else if(symptomCode.Equals("s1" ,StringComparison.OrdinalIgnoreCase))
        {
            return "s1: Headache";
        }
        else if(symptomCode.Equals("s2", StringComparison.OrdinalIgnoreCase))
        {
            return "s2: Skin rashes";
        }
        else if(symptomCode.Equals("s3", StringComparison.OrdinalIgnoreCase))
        {
            return "s3: Dizziness";
        }
        else
        {
            return "Unkown";
        }

    }


    public override string ToString()
    {
        return $"Name :{name} \nAge :{age} \nGender :{gender} \nDiabetes Suffer :{GetDiabetesSuffer()}";
    }


}
