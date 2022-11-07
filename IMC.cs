using System;
namespace /*1*/SempreEmForma{ 
 public class /*2*/Pessoa{
    /*3*/private int peso;
    /*3*/private double altura;
    /*11*/private string nome;
    
    //método construtor/*4*//*7*/
    Pessoa(int peso, double altura, /*12*/string nome){
        this.peso = peso;
        this.altura = altura;
        this.nome = nome;
        
    } 

    //Métodos GET /*5*//*7*/
    public int getPeso(){
        return(peso);     
    }

    public double getAltura(){
        return(altura);     
    }
    
    public string /*13*/getNome(){
        return(nome);     
    }

    //Métodos SET /*5*//*7*/
    public void setPeso(int peso){
        this.peso = peso;    
    }

    public void setAltura(double altura){
        this.altura = altura;    
    }
     
    public void /*13*/setNome(string nome){
        this.nome = nome;    
    }
    
    //Métodos Geral/*7*/
    public double /*6*/CalculoIMC(){
        double IMC = 0;
        IMC = peso/(altura * altura); 
        return IMC;
    } 
    
    public string /*16*/TabelaIMC(){
        double IMC = 0;
        string tabela = " ";
        IMC = peso/(altura * altura); 
        
        if(IMC < 18.5){
            return tabela = "BAIXO";
        }else if(IMC >= 18.5 && IMC < 25){
            return tabela = "NORMAL";
        }else if(IMC >= 25){
            return tabela = "ALTO";
        }else{
            return tabela;
        }
    }
    
    public int /*17*/engordar(){
        while(peso != 70){
            peso ++;
        }
        return peso;
    }
    
    public int /*18*/emagrecer(){
         while(peso != 50){
            peso --;
        }
        return peso;
    }
    
 
   //Destructor
    ~Pessoa(){
     
    } 
    public static void Main(){
        int peso;
        double altura;
        string nome;
        /*19*/try{
            /*15*/
            Console.Write ("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.Write ("Qual seu peso? ");
            peso =  int.Parse(Console.ReadLine ());

            Console.Write ("Qual sua altura? ");
            altura = float.Parse(Console.ReadLine ());
            
            /*8*///Pessoa pessoa1 = new Pessoa(62, 1.55, /*11*/"Jerson");
            Pessoa pessoa1 = new Pessoa(peso, altura, nome);
       
            /*14*/Console.WriteLine("O nome da pessoa é {0}", pessoa1.getNome());
            /*10*/Console.WriteLine("O peso de {0}", pessoa1.getNome() + " é: " + pessoa1.getPeso()); 
            /*10*/Console.WriteLine("A altura de {0}", pessoa1.getNome() + " é: " + pessoa1.getAltura()); 
           
            /*9*/Console.WriteLine("O IMC de {0}", pessoa1.getNome() + " é: " + pessoa1.CalculoIMC()); 
            Console.WriteLine("O IMC de {0}", pessoa1.getNome() + " é: " + pessoa1.TabelaIMC());
            
            Console.WriteLine("\nPassou um mês");
            Console.WriteLine(pessoa1.getNome() + " engordou para " + pessoa1.engordar(), " Kg");
            
            Console.WriteLine("\nPassou 2 meses");
            Console.WriteLine(pessoa1.getNome() + " emagreceu para " + pessoa1.emagrecer(), " Kg");

        }/*19*/catch(FormatException){ 
            Console.WriteLine("Formato de entrada errado!");
        }
   }/*main*/

 }/*Pessoa*/

}/*SempreEmForma*/
