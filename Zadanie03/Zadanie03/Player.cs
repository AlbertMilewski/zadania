using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Zadanie03
{
     class Player
    {
        public List<Song> lista = new List<Song>();
        //public Song[] lista = new Song[10];
        int songNumber = 0;
        int i =0;
        public void Add(Song song)
        {
            //lista[songNumber] = song;
            lista.Add(song);
            songNumber++;
        }
        public void Remove(int songNumber)
        {
            lista.RemoveAt(songNumber);
        }
        public void PlayAll()
        {
            foreach (Song song in lista)
            {
                song.Play();
                Thread.Sleep(1000);
            }
        }
        public void PlayOne(int songNumber)
        {
            lista[songNumber].Play();
        }
        public void Show()
        {
            foreach(Song song in lista)
            {
                Console.Write(lista.IndexOf(song));
                Console.Write(". ");
                Console.WriteLine(song);
                i++;
            }
        }

    }
}
