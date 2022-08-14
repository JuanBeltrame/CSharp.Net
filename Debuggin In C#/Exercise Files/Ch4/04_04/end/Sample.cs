using System;

namespace _04_03
{
        class Sample
    {
        static Tuple<double,double>[] edgePatients = new Tuple<double,double>[]{ 
                new Tuple<double, double>(0.0, 0.0), 
                new Tuple<double, double> (0.0, 5.0), 
                new Tuple<double, double> (5.0, 0.0),
                new Tuple<double, double> (-2.0, -2.0),
                new Tuple<double, double> (-2.0, 3.0),
                new Tuple<double, double> (3, -2.0)
        };

        static double feetToInches(double feet, double inches) {
            return (feet * 12) + inches;
        }

        static double nextDouble(Random rnd, double min, double max) {
            return rnd.NextDouble() * (max-min) + min;
        }

        static Tuple<double, double>[] initalizePatients(int size) {
            Tuple<double, double>[] patients = new Tuple<double, double>[size + Sample.edgePatients.Length];
            Random rnd = new Random();
            int i = 0;

            while(i < size) {
                // Calculate height
                double feet = Math.Round(nextDouble(rnd, 4, 7), 2); // random ft value between 4 and 6
                double inches = Math.Round(nextDouble(rnd, 0, 12), 2); // random inch value between 0 and 11
                double height = Math.Round(feetToInches(feet, inches), 2);

                // Calculate weight
                double weight = Math.Round(nextDouble(rnd, 120, 281), 2); // random weight value between 120 and 280

                patients[i] = new Tuple<double, double>(height, weight);
                i++;
            }


            // Add edge cases
            while (i < patients.Length) {
                patients[i] = Sample.edgePatients[Math.Abs(size - i)];
                i++;
            }

            return patients;
        }

        static double calculate_BMI(double height, double weight) {
            if (height <= 0 || weight <= 0) {
                Console.WriteLine("Height: " + height + " Weight: " + weight + " BMI: Invalid for height or weight: Automatic 0");
                return 0; 
            }
            double bmi = (weight / Math.Pow(height, 2)) * 703;
            Console.WriteLine("Height: " + height + " Weight: " + weight + " BMI: " + bmi);
            return bmi;
        }

        static double[] calculate_BMI_Collection(Tuple<double, double>[] patients) {
            double[] bmi_collection = new double[patients.Length];
            for(int i = 0; i < bmi_collection.Length; i++) {
                bmi_collection[i] = Math.Round(calculate_BMI(patients[i].Item1, patients[i].Item2), 2);
            }
            return bmi_collection;
        }

        static void Main(string[] args)
        {
            // Create random patients...
            Tuple<double, double>[] patients = initalizePatients(10);

            // Find BMI of each patient
            double[] patients_bmi = calculate_BMI_Collection(patients);

        }
    }

}
