using System;
using System.Collections.Generic;
using System.Text;
using App12_ProjMVVM.Model;

namespace App12_ProjMVVM.Armazenamento
{
   public class Armazenamento
    {
        public static Jogo Jogo { get; set; }
        public static short RodadaAtual { get; set; }

        public static string[][] Palavras =
        {
            //faceis - 1
            new string []{ "Olho", "Língua", "Chinelo", "Bola", "Ping-Pong"},

            //medias - 3
            new string []{ "Carpinteiro", "Amarelo", "Limão", "Abelha"},

            //dificeis - 5
            new string []{ "Cisterna", "Lanterna", "Batman vs Superman", "Notebook" },
        };
    }
}
