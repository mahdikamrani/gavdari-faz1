using System.ComponentModel.DataAnnotations;

namespace gavdari_faz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }
    }



    abstract public class animal
    {
        public  int BirthDate;
        static readonly int maxlife;
        public float weight;
        public bool gender;
        public string name;

        public float stressfactor()
        {
            return
        }
        public int life()
        {
            return
        }
        public float priorty()
        {
            return
        }

        public int Costperday()
        {
            return
        }
        public int value perday()
        {

        }
    }


    public class enviroment
    {
        public double HealthparameterTDS;
        public double HealthparameterTEMP;
        public double HealthparameterDB;
        public double HealthparameterOX;
        public double HealthparameterAQI;
        public double HealthparameterDENSITY;
        
    }

    public class HealthParameter<T>
    {
        public string name;
        public T current;
        public T Standard;

        public float StressFActor()
        {
            return
        }

    }
    public class cow : animal
    {
        public int birthdate;
        static readonly int maxlife;
        static int number;

    }
    public class sheep : animal
    {
        public int birthdate;
        static readonly int maxlife;
        static int number;

    }


    public class cowparameter<T>
    {
        public int Healthparametertimetostand;
        public int HealthparameterTimeToDeal;
        public int HealthparameterTimeToRelax;
        public int HealthparameterNumberOfMeal;
        public int HealthparameterNumberOfmilkProduction;
        public int date;

    }

}