Algoritmo "feito por mim doa��o"

Var

   d: real
   Valor: real
   sg: real

Inicio
       EscrevaL("*****************")
       EscrevaL("*****Bem-Vindo****")
       EscrevaL("*****************")
       EscrevaL("Com quanto deseja ajudar?")
       EscrevaL("*****************")

       EscrevaL("[1] Para doar R$10")
       EscrevaL("[2] Para doar R$20")
       EscrevaL("[3] Para doar R$30")
       Escreval("[4] Para doar qualquer valor")
       Escreval("[5] Para cancelar!")

       Escreva("Deseja prosseguir? 1-Sim 2-N�o: ")
                       leia(sg)
                       
         se (sg = 1)  entao
          Escreva("Qual das op��es deseja escolher 1 a 5: ")
           leia(d)

      escolha d
       caso 1
        Valor <- 10
        
        caso 2
         Valor <- 20
        
         caso 3
          Valor <- 30
        
          caso 4
           Escreva("Qual valor deseja doar?")
            leia(Valor)
        
            caso 5
             Valor <- 0
        
        senao
         Escreva("Voc� n�o fez nenhuma doa��o, mesmo assim ficamos gratos pela sua presen�a")

       fimescolha
         fimse

       EscrevaL("***********************************")
       EscrevaL("Voc� doou ", "R$",Valor , " Obrigado!!")
       EscrevaL("            VOLTE SEMPRE!!         ")
       EscrevaL("***********************************")



Fimalgoritmo