using System;
using System.Collections.Generic;
class Program {
  public static void Main (string[] args) {
    int i = 0, j = 0, nucleos = 0;
    while (j == 0){
    do{
    Console.WriteLine ("\nOla, Mundo!\nSou a IA e estou aqui para ajudar o OSID a ser mais reconhecido!");
    Console.WriteLine ("O OSID é uma entidade filantrópica privada, sem fins lucrativos que oferece serviços de saúde, assistência social e ensino aos pobres e necessitados de forma gratuita.");
    }while (i<=0);
      i++;
      
        Console.WriteLine($"\nEscreva:\n1 para conhecer mais sobre essa instituição;\n2 para contar quantos núcleos dessa instituição existem;\n3 para repetir minha introdução;\n4 para sair.");
        int escolha1 = int.Parse(Console.ReadLine());
      
     switch (escolha1){
   case 1:
       Console.WriteLine("\nAs Obras Sociais Irmã Dulce é uma entidade filantrópica privada, sem fins lucrativos, fundada em 26 de maio de 1959 pela santa brasileira Irmã Dulce. É composto de 17 núcleos, 16 deles no Largo de Roma, na Cidade Baixa em Salvador, Bahia.\n\nSe desejar entrar em contato, digite 1; \nSe prefere saber como se tornar um voluntário, digite 2.\nSe quiser voltar ao menu principal digite 3");
       int escolha2 = Convert.ToInt32(Console.ReadLine());
       if (escolha2 == 1){
        Console.WriteLine("\nTelefone\n(71) 99168-1782\n\nE-mail\nvoluntariado@irmadulce.org.br\n\nSite\nhttps://doe.irmadulce.org.br");
       
       }
       else if (escolha2 == 2){
        Console.WriteLine("1. Faça contato com nossa Central de relacionamento com Voluntário;\n2. Informe suas habilidades e tempo disponível;\n3. Traga seu sorriso e afeto para distribuir em nossas obras!\nSeja bem vindo(a)!");
       }
       else{
         Console.WriteLine("");
       }
       break;
     case 2:
        for (int x = 0; x<=21; x++){
          x++;
          nucleos=x;
        }
       Console.WriteLine($"Hoje contam com um perfil de serviços distribuídos em {nucleos} núcleos.");
        break;
     case 3:
        i = 0;
        break;
     case 4:
        j++;
        break;
    default:
        Console.WriteLine("Escolha uma opção inválida!!!");
       break;
     }
    }
  }
}