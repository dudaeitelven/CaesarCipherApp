using System;
using System.Collections.Generic;
using System.IO;

namespace FileCaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração das variáveis
            string encrypt = "";
            string palavra = "";
            int avancar = 0;

            //método write escreve na tela do prompt do usuario
            Console.Write("|---------------------------------|\n");
            Console.Write("| 1 - Criptografar um mensagem    |\n");
            Console.Write("| 0 - Sair                        |\n");
            Console.Write("|---------------------------------|\n");
            Console.Write(" Escolha a opçao: ");

            //Aqui é feito uma conversão, pois o opcao é inicialmente uma string
            int opcao = int.Parse(Console.ReadLine());

            //depois da conversão o switch verifica a opcao digitada
            switch (opcao)
            {
                case 1:
                    List<string> Tweets = new List<string>();
                    string FileToRead = "decryptme.txt";

                    Console.Write("Quantas vezes você gostaria de avançar ?: ");
                    avancar = Convert.ToInt32(Console.ReadLine());

                    //Carregando o arquivo com os tweets
                    using (StreamReader sr = File.OpenText(FileToRead))
                    {
                        string cab = sr.ReadLine();
                        while (!sr.EndOfStream)
                        {
                            string[] linha = sr.ReadLine().Split(',');
                            string id_user = string.Empty;
                            
                            try
                            {
                                id_user = linha[0].Trim();
                            }
                            catch (Exception e)
                            {
                                id_user = "";
                            }


                        }
                    }



                    ////enquanto a palavra for menor que i
                    //for (int i = 0; i < palavra.Length; i++)

                    //{
                    //    //Devolve o codigo ASCII da letra
                    //    int ASCII = (int)palavra[i];

                    //    //Coloca a chave fixa adicionando 10 posições no numero da tabela ASCII
                    //    int ASCIIC = ASCII + 10;

                    //    //Concatena o texto e o coloca na variável
                    //    encrypt += Char.ConvertFromUtf32(ASCIIC);
                    //}

                    ////Mostra o resultado final, concatenando a variável em que está o texto cifrado
                    //Console.Write("Resultado: " + encrypt);

                    ////Aguarda o usuário pressionar uma tecla para sair
                    //Console.ReadKey();

                    //representa o final do case 1
                    break;
            }
        }
    }
}
