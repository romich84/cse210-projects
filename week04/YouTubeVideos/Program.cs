using System;
using YouTubeVideos;

class Program
{
    static void Main(string[] args)
    {
        Video v1 = new Video("Programming with C#", "Romina Ch", 120);
        Comment c1 = new Comment("Cecilia Guevara", "Good video, very useful");
        Comment c2 = new Comment("Celeste Carvallo", "Good video");
        Comment c3 = new Comment("Hugo Pérez", "Nice job");
        Comment c4 = new Comment("Hugo Pereyra", "Estoy aprendiendo programación, muy útil");
        v1.AddComment(c1);
        v1.AddComment(c2);
        v1.AddComment(c3);
        v1.AddComment(c4);
        v1.GetDisplayVideo();
        Console.WriteLine("----------------------------");
        Video v2 = new Video("Swim - BTS", "BIGHIT MUSIC", 180);
        Comment c5 = new Comment("Ann", "Still swimming :-)");
        Comment c6 = new Comment("Steve", "Guys, you are awesome");
        Comment c7 = new Comment("La Roca", "You rock!");
        Comment c8 = new Comment("Miranda Lisa Army", "Me encantó el nuevo estilo urbano");
        v2.AddComment(c5);
        v2.AddComment(c6);
        v2.AddComment(c7);
        v2.AddComment(c8);
        v2.GetDisplayVideo();
        Console.WriteLine("----------------------------");
        Video v3 = new Video("Easy Lemon Pie", "Paula Cooks", 120);
        Comment c9 = new Comment("Julia Valenzuela", "Delicious");
        Comment c10 = new Comment("Lucia Rodriguez", "I'll make it next week");
        Comment c11 = new Comment("Margarita N", "Very tasty");
        Comment c12 = new Comment("Rita Peña", "Una receta super fácil y deliciosa");
        v3.AddComment(c9);
        v3.AddComment(c10);
        v3.AddComment(c11);
        v3.AddComment(c12);
        v3.GetDisplayVideo();
        Console.WriteLine("----------------------------");
        Video v4 = new Video("Cómo jugar al LOL de cero a experto", "Guido Sosa", 240);
        Comment c13 = new Comment("Brian Taylor", "Wow! Super!");
        Comment c14 = new Comment("Tommy W", "Good strategies");
        Comment c15 = new Comment("Michael Tanner", "Very good video, bro");
        Comment c16 = new Comment("Lucas Lozada", "Para alguien que recién comienza es lo más!");
        v4.AddComment(c13);
        v4.AddComment(c14);
        v4.AddComment(c15);
        v4.AddComment(c16);
        v4.GetDisplayVideo();

    }
}