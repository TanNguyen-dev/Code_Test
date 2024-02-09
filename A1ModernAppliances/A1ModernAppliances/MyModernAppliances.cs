using ModernAppliances.Entities;
using ModernAppliances.Entities.Abstract;
using ModernAppliances.Helpers;

namespace ModernAppliances
{
    /// <summary>
    /// Manager class for Modern Appliances
    /// </summary>
    /// <remarks>Author: Malek Mansour, Tan Nguyen, Ye Phone Kyaw </remarks>
    /// <remarks>Date: 2024-02-6 </remarks>
    internal class MyModernAppliances : ModernAppliances
    {
        /// <summary>
        /// Option 1: Performs a checkout
        /// </summary>
        public override void Checkout()
        {
            Console.WriteLine("Enter the item number of an appliance: ");

            long itemNumber;

            string userInput = Console.ReadLine();

            // Convert user input from string to long and store as item number variable.
            long.TryParse(userInput, out itemNumber);

            // Create 'foundAppliance' variable to hold appliance with item number
            Appliance foundAppliance = null;

            // Loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test appliance item number equals entered item number
                if (appliance.ItemNumber == itemNumber)
                {
                    // Assign appliance in list to foundAppliance variable
                    foundAppliance = appliance;

                    // Break out of loop (since we found what need to)
                    break;
                }
            }

            // Test appliance was not found (foundAppliance is null)
            if (foundAppliance == null)
            {
                // Write "No appliances found with that item number."
                Console.WriteLine("No appliances found with that item number.");
            }
            // Otherwise (appliance was found)
            else
            {
                // Test found appliance is available
                if (foundAppliance.IsAvailable)
                {
                    // Checkout found appliance
                    foundAppliance.Checkout();

                    // Write "Appliance has been checked out."
                    Console.WriteLine("Appliance has been checked out.");
                }
                // Otherwise (appliance isn't available)
                else
                {
                    // Write "The appliance is not available to be checked out."
                    Console.WriteLine("The appliance is not available to be checked out.");
                }
            }

        }

        /// <summary>
        /// Option 2: Finds appliances
        /// </summary>
        public override void Find()
        {
            Console.WriteLine("Enter brand to search for:");

            // Create string variable to hold entered brand
            string enteredBrand = Console.ReadLine();

            // Create list to hold found Appliance objects
            List<Appliance> foundAppliances = new List<Appliance>();

            // Iterate through loaded appliances
            foreach (var appliance in Appliances)
            {
                // Test current appliance brand matches what user entered
                if (appliance.Brand.Equals(enteredBrand, StringComparison.OrdinalIgnoreCase))
                {
                    // Add current appliance in list to found list
                    foundAppliances.Add(appliance);
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundAppliances, 0);
        }

        /// <summary>
        /// Displays Refridgerators
        /// </summary>
        public override void DisplayRefrigerators()
        {
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Double doors");
            Console.WriteLine("3 - Three doors");
            Console.WriteLine("4 - Four doors");
            Console.Write("Enter number of doors: ");

            // Create variable to hold entered number of doors
            int enteredDoors;

            // Get user input as string and assign to variable
            string userInput = Console.ReadLine();

            // Convert user input from string to int and store as number of doors variable.
            int.TryParse(userInput, out enteredDoors);

            // Create list to hold found Appliance objects
            List<Appliance> foundRefrigerators = new List<Appliance>();

            // Iterate/loop through Appliances
            foreach (var appliance in Appliances)
            {
                // Test that current appliance is a refrigerator
                if (appliance is Refrigerator)
                {
                    // Down cast Appliance to Refrigerator
                    Refrigerator refrigerator = (Refrigerator)appliance;

                    // Test user entered 0 or refrigerator doors equals what user entered.
                    if (enteredDoors == 0 || refrigerator.Doors == enteredDoors)
                    {
                        // Add current appliance in list to found list
                        foundRefrigerators.Add(appliance);
                    }
                }
            }

            // Display found appliances
            DisplayAppliancesFromList(foundRefrigerators, 0);
        }

        /// <summary>
        /// Displays Vacuums
        /// </summary>
        /// <param name="grade">Grade of vacuum to find (or null for any grade)</param>
        /// <param name="voltage">Vacuum voltage (or 0 for any voltage)</param>
        public override void DisplayVacuums()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Residential"
            // Write "2 - Commercial"
            // Write "Enter grade:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("2 - Residential");
            Console.WriteLine("3 - Commercial");
            Console.WriteLine("Enter grade:");


            // Get user input as string and assign to variable
            string gradeInput = Console.ReadLine();

            // Create grade variable to hold grade to find (Any, Residential, or Commercial)
            string grade;
            // Test input is "0"
            // Assign "Any" to grade
            // Test input is "1"
            // Assign "Residential" to grade
            // Test input is "2"
            // Assign "Commercial" to grade
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;
            switch (gradeInput)
            {
                case "0":
                    grade = "Any"; break;
                case "1":
                    grade = "Residential"; break;
                case "2":
                    grade = "Commercial"; break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }


            // Write "Possible options:"
            // Write "0 - Any"
            // Write "1 - 18 Volt"
            // Write "2 - 24 Volt"
            // Write "Enter voltage:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - 18 Volt");
            Console.WriteLine("2 - 24 Volt");
            Console.WriteLine("Enter voltage:");


            // Get user input as string
            // Create variable to hold voltage
            string voltageInput = Console.ReadLine();
            int voltage;

            // Test input is "0"
            // Assign 0 to voltage
            // Test input is "1"
            // Assign 18 to voltage
            // Test input is "2"
            // Assign 24 to voltage
            // Otherwise
            // Write "Invalid option."
            // Return to calling (previous) method
            // return;

            switch (voltageInput)
            {
                case "0":
                    voltage = 0; break;
                case "1":
                    voltage = 18; break;
                case "2":
                    voltage = 24; break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            // Create found variable to hold list of found appliances.
            List<Appliance> foundVacuums = new List<Appliance>();

            // Loop through Appliances
            // Check if current appliance is vacuum
            // Down cast current Appliance to Vacuum object
            // Vacuum vacuum = (Vacuum)appliance;

            // Test grade is "Any" or grade is equal to current vacuum grade and voltage is 0 or voltage is equal to current vacuum voltage
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            foreach (var App in Appliances)
            {
                if (App is Vacuum)
                {
                    Vacuum vacuum = (Vacuum)App;
                    if (grade == "Any" || (grade == vacuum.Grade && (voltage == 0 || voltage == vacuum.voltage)))
                        foundVacuums.Add(App);
                }
            }

            DisplayAppliancesFromList(foundVacuums, 0);

        }

        /// <summary>
        /// Displays microwaves
        /// </summary>
        public override void DisplayMicrowaves()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Kitchen"
            // Write "2 - Work site"
            // Write "Enter room type:"
            Console.WriteLine("Possible options:");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Kitchen");
            Console.WriteLine("2 - Work site");
            Console.WriteLine("Enter room type:");

            // Get user input as string and assign to variable
            string microwaveInput = Console.ReadLine();
            // Create character variable that holds room type
            char roomType;

            // Test input is "0"
            // Assign 'A' to room type variable
            // Test input is "1"
            // Assign 'K' to room type variable
            // Test input is "2"
            // Assign 'W' to room type variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            // return;
            switch (microwaveInput)
            {
                case "0":
                    roomType = 'A'; break;
                case "1":
                    roomType = 'K'; break;
                case "2":
                    roomType = 'W'; break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            // Create variable that holds list of 'found' appliances

            // Loop through Appliances
            // Test current appliance is Microwave
            // Down cast Appliance to Microwave

            // Test room type equals 'A' or microwave room type
            // Add current appliance in list to found list

            // Display found appliances
            // DisplayAppliancesFromList(found, 0);
            List<Appliance> foundMicrowave = new List<Appliance>();

            foreach (var App in Appliances)
            {
                if (App is Microwave)
                {
                    Microwave microwave = (Microwave)App;
                    if (roomType == 'A' || roomType == microwave.RoomType)
                        foundMicrowave.Add(App);
                }
            }

            DisplayAppliancesFromList(foundMicrowave, 0);
        }

        /// <summary>
        /// Displays dishwashers
        /// </summary>
        public override void DisplayDishwashers()
        {
            // Write "Possible options:"

            // Write "0 - Any"
            // Write "1 - Quietest"
            // Write "2 - Quieter"
            // Write "3 - Quiet"
            // Write "4 - Moderate"
            Console.WriteLine("Possible options: ");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Quietest");
            Console.WriteLine("2 - Quieter");
            Console.WriteLine("3 - Quiet");
            Console.WriteLine("4 - Moderate");

            // Write "Enter sound rating:"
            Console.WriteLine("Enter sound rating");


            // Get user input as string and assign to variable
            string dishwasherInput = Console.ReadLine();


            // Create variable that holds sound rating
            string soundRating;


            // Test input is "0"
            // Assign "Any" to sound rating variable
            // Test input is "1"
            // Assign "Qt" to sound rating variable
            // Test input is "2"
            // Assign "Qr" to sound rating variable
            // Test input is "3"
            // Assign "Qu" to sound rating variable
            // Test input is "4"
            // Assign "M" to sound rating variable
            // Otherwise (input is something else)
            // Write "Invalid option."
            // Return to calling method
            switch (dishwasherInput)
            {
                case "0":
                    soundRating = "Any";
                    break;
                case "1":
                    soundRating = "Qt";
                    break;
                case "2":
                    soundRating = "Qr";
                    break;
                case "3":
                    soundRating = "Qu";
                    break;
                case "4":
                    soundRating = "M";
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    return;
            }

            // Create variable that holds list of found appliances
            List<Appliance> foundDishwasher = new List<Appliance>();


            // Loop through Appliances
            // Test if current appliance is dishwasher
            // Down cast current Appliance to Dishwasher

            // Test sound rating is "Any" or equals soundrating for current dishwasher
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (appliance is Dishwasher)
                {
                    Dishwasher dishwasher = (Dishwasher)appliance;
                    if (soundRating == "Any" || soundRating == dishwasher.SoundRating)
                    {
                        foundDishwasher.Add(appliance);
                    }
                }
            }
            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, 0);
            DisplayAppliancesFromList(foundDishwasher, 0);

        }

        /// <summary>
        /// Generates random list of appliances
        /// </summary>
        public override void RandomList()
        {
            // Write "Appliance Types"

            // Write "0 - Any"
            // Write "1 – Refrigerators"
            // Write "2 – Vacuums"
            // Write "3 – Microwaves"
            // Write "4 – Dishwashers"
            Console.WriteLine("Appliance Typrs");
            Console.WriteLine("0 - Any");
            Console.WriteLine("1 - Refrigerators");
            Console.WriteLine("2 - Vacuums");
            Console.WriteLine("3 - Microwaves");
            Console.WriteLine("4 - Dishwashers");

            // Write "Enter type of appliance:"
            Console.Write("Enter type of appliance: ");


            // Get user input as string and assign to appliance type variable
            string randomTypeInput = Console.ReadLine();


            // Write "Enter number of appliances: "
            Console.WriteLine("Enter number of appliances: ");


            // Get user input as string and assign to variable
            string randomInput = Console.ReadLine();


            // Convert user input from string to int
            int num = int.Parse(randomInput);


            // Create variable to hold list of found appliances
            List<Appliance> foundRandom = new List<Appliance>();


            // Loop through appliances
            // Test inputted appliance type is "0"
            // Add current appliance in list to found list
            // Test inputted appliance type is "1"
            // Test current appliance type is Refrigerator
            // Add current appliance in list to found list
            // Test inputted appliance type is "2"
            // Test current appliance type is Vacuum
            // Add current appliance in list to found list
            // Test inputted appliance type is "3"
            // Test current appliance type is Microwave
            // Add current appliance in list to found list
            // Test inputted appliance type is "4"
            // Test current appliance type is Dishwasher
            // Add current appliance in list to found list
            foreach (var appliance in Appliances)
            {
                if (num == 0)
                {
                    foundRandom.Add(appliance);
                }
                else if (num == 1 && randomTypeInput == "Refrigerator")
                {
                    foundRandom.Add(appliance);
                }
                else if (num == 2 && randomTypeInput == "Vacuum")
                {
                    foundRandom.Add(appliance);
                }
                else if (num == 3 && randomTypeInput == "Microwave")
                {
                    foundRandom.Add(appliance);
                }
                else if (num == 4 && randomTypeInput == "Dishwasher")
                {
                    foundRandom.Add(appliance);
                }
            }

            // Randomize list of found appliances
            // found.Sort(new RandomComparer());

            // Display found appliances (up to max. number inputted)
            // DisplayAppliancesFromList(found, num);
            foundRandom.Sort(new RandomComparer());
            DisplayAppliancesFromList(foundRandom, num);
        }
    }
}