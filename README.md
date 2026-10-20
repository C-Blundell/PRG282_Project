Baobab Ridge Wildlife Rehabilitation Records System 

Members:
Hugo Pelser - 604741
Onthatile Mashilo - 604847
Ardent Svosvai - 605175
Christopher Blundell - 604377

How to run:
Clone the repository from GitHub or download the project files.
Open the solution file (.sln) in Visual Studio.
Build the solution using Build → Build Solution.
Run the application using Start or F5.

Features:
Add Animal: Register an animal with its ID, name, species, age and recovery score.
View Animals: Display valid animal records in a data-grid.
Update Animal: Search for or select an animal, edit its details and recalculate its status and housing unit.
Delete Animal: Remove an animal record after confirming the deletion.
Generate Summary Report: Calculate the total number of animals, average age, average recovery score and number of animals in each status.

animals.txt 
Stores all animal records. Each line represents one animal and contains seven fields. The application reads this file when it starts and updates it when animal records change.

summary.txt 
Stores a readable report generated from the animal records. It includes the total number of animals, average age, average recovery score and counts for each status. The file is overwritten whenever a new report is generated.
