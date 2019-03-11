<b>Задание 1:</b>

Дефинирайте клас Person с полета за име и години.
Добавете 3 конструктора:

                - Първият без аргументи и резултата е "Без име; Години = 1;
                - Вторият приема само параметър за години и резултата е "Без име; Години = параметъра";
                - Третият приема параметри име и години и резултата е "Името; Годините";
             
Използвайте класа Person. Създайте нов клас Family. Класа трябва да съдържа списък от хора, метод за добавяне на нови хора и метод за изкарване на най-стария човек.
Напишете метод, който чете имената и годините на N на брой хора и ги добавя в списъка. Напишете метод, който изкарва всичко хора, които Age > 30.

<b>Задание 2:</b>

You are the owner of a courier company and want to make a system for tracking your cars and their cargo. 
Define a class Car that holds information about model, engine, cargo and a collection of exactly 4 tires. The engine, cargo and tire should be separate classes. Create a constructor that receives all information about the Car and creates and initializes its inner components (engine, cargo and tires).

On the first line of input you will receive a number N - the amount of cars you have. On each of the next N lines you will receive information about a car in the format “<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType> <Tire1Pressure> <Tire1Age> <Tire2Pressure> <Tire2Age> <Tire3Pressure> <Tire3Age> <Tire4Pressure> <Tire4Age>” where the speed, power, weight and tire age are integers, tire pressure is a double. 
After the N lines you will receive a single line with one of 2 commands: “fragile” or “flamable”. If the command is “fragile” print all cars whose Cargo Type is “fragile” with a tire whose pressure is  < 1. If the command is “flamable” print all cars whose Cargo Type is “flamable” and have Engine Power > 250. The cars should be printed in order of appearing in the input.
    
<b>Задание 3:</b>

Да се създаде приложение /.net, web, console – няма значение/ с потребителски интерфейс:
Системата трябва да изпълнява следните функционалности:
-	входен екран, през който създадени потребители да се оторизират в системата посредством потребителско име и парола
-	преглед/редакция на списък с неща за вършене: Tasks (To-Do list)
всеки потребител да може да вижда/редактира само собствените си задачи
-	да може да се маркират/ архивират съответните редове като приключени 
-	приключените Tasks да се виждат отделно в списък архив.
