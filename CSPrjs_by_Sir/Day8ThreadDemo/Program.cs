using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Day8ThreadDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MovieSystem movie = new MovieSystem();
            ThreadStart ts1 = new ThreadStart(movie.PlayMovie);

            MusicSystem music = new MusicSystem();
            ThreadStart ts2 = new ThreadStart(music.PlayMusic);

            ParameterizedThreadStart ts3 = new ParameterizedThreadStart(music.PlayMusic);


            Thread t1 = new Thread(ts1);
            Thread t2 = new Thread(ts2);
            Thread t3 = new Thread(ts3);

            // t1.Start();
            // t2.Start();

            // t3.Start("Teri Mitti Me...");

            //t1.Abort();
            //t1.Suspend();
            //t1.Resume();



            ParameterizedThreadStart ps1 = new ParameterizedThreadStart(FileOperation.WriteFile);
            ParameterizedThreadStart ps2 = new ParameterizedThreadStart(FileOperation.ReadFile);

            Thread T1 = new Thread(ps1);
            Thread T2 = new Thread(ps2);

            FileStream fs = new FileStream("f:\\test.txt", FileMode.Create, FileAccess.Write);

            T1.Start(fs);
            T2.Start(fs);



        }
    }

    

    class MovieSystem
    {
         public void PlayMovie()
        {
            Console.WriteLine("Movie started");
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("Playing movie:" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Movie finished");
        }
    }

    class MusicSystem
    {


        public void PlayMusic()
        {
            
            //ParameterizedThreadStart ts = new ParameterizedThreadStart(this.PlayMusic);
            //Thread tchild = new Thread(ts);
            //tchild.Start("Ae Dil....");
            //tchild.Join();

            Console.WriteLine("Music started");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\tPlaying music:" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Music stopped");
        }
        public void PlayMusic(object song)
        {
            Console.WriteLine("Music started");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\t\tPlaying song(" + song.ToString() + "):" + i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("Music stopped");
        }
    }




    class FileOperation
    {
        public static void WriteFile(object fs)
        {
            Monitor.Enter(fs);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("File writing:" + i);
                Thread.Sleep(1000);
            }
            Monitor.Exit(fs);
        }
        public static void ReadFile(object fs)
        {
            Monitor.Enter(fs);
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("File reading:" + i);
                Thread.Sleep(1000);
            }
            Monitor.Exit(fs);
        }
    }
}
