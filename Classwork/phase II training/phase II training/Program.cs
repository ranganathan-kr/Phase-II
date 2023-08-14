// See https://aka.ms/new-console-template for more information
using phase_II_training;
/*Mypets mypets = new(2, 2, 4, "Dog");
Animal.sleep();
Animal.eat();
mypets.aboutme();
mypets.sound ();*/

IMypets mypets = new IMypets(2, 2, 4, "Dog");

mypets.aboutme();
mypets.sound ();
mypets.sleep();