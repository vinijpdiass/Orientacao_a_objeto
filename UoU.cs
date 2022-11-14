using System;
namespace /*1*/Uordi_ofi_Uorcrefiti{ 
//2,16, 17
public abstract class Heroi{
    private string nome;
    protected double ptsVida;

    public Heroi (string nome, double ptsVida){
        this.nome = nome;
        this.ptsVida = ptsVida;
    }
    
    //Métodos GET
    public string getNome(){
      return(nome);     
    }

    public double getPtsVida(){
      return(ptsVida);     
    }

    //Métodos SET
    public void setNome(string nome){
     this.nome = nome;    
    }

    public void setPtsVida(double ptsVida){
     this.ptsVida = ptsVida;    
    }
    
    public virtual void LancarMagia(){}
    public virtual void AtacarComArma(){}

    public virtual void ReduzirVida(){
        this.ptsVida = ptsVida - 30;
    }
    public virtual void AumentarVida(){
        this.ptsVida= ptsVida + 20;
    }
    //Destrutor
    ~Heroi(){
     
    }
}//Heroi
//6 e 7
public class HeroiAlianca:Heroi{
    public HeroiAlianca (string nome,int ptsVida):base(nome, ptsVida){
        
    }
    public override void AumentarVida (){
        base.AumentarVida ();
        this.ptsVida += 0.2;
    }
    public override void LancarMagia(){
        Console.WriteLine ("Força Rutilante!!!");
    }
    public override void AtacarComArma(){
        Console.WriteLine ("Espada Íntegra!!!!!");
    }
}//HeroiAlianca
//11 e 12
public class HeroiHorda:Heroi{
    public HeroiHorda (string nome,int ptsVida):base(nome, ptsVida){
        
    }
    public override void ReduzirVida (){
        base.ReduzirVida ();
        this.ptsVida -= 0.2;
    }
    public override void LancarMagia(){
        Console.WriteLine ("Caminho de chamas!!!");
    }
    public override void AtacarComArma(){
        Console.WriteLine ("Machado do berserker!!!!!");
    }
}//HeroiHorda
 public class UoU{
   public static void Main(){
      //18 e 19
      //Aliança
      Heroi ali = new HeroiAlianca("Zadur", 100);
      
      Console.WriteLine("\nHeroi Aliança"); 
      Console.WriteLine("O nome do heroi é: {0}", ali.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", ali.getNome(), ali.getPtsVida()); 
      
      Console.WriteLine("{0} sofreu um ataque", ali.getNome()); 
      ali.ReduzirVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", ali.getPtsVida()); 
      
      Console.WriteLine("{0} rapidamente se cura", ali.getNome()); 
      ali.AumentarVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", ali.getPtsVida()); 
      
      Console.WriteLine("{0} sem perder tempo lança uma magia", ali.getNome()); 
      ali.LancarMagia();
      Console.WriteLine("{0} logo em seguida desfere um golpe com sua arma", ali.getNome()); 
      ali.AtacarComArma();
      
      Console.WriteLine("\ne a batalha continua..."); 
      
      
      //Horda
      Heroi hor = new HeroiHorda("Zodar", 100);
      
      Console.WriteLine("\nHeroi Horda"); 
      Console.WriteLine("O nome do heroi é: {0}", hor.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", hor.getNome(), hor.getPtsVida()); 
      
      Console.WriteLine("{0} sofreu um ataque", hor.getNome()); 
      hor.ReduzirVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", hor.getPtsVida()); 
      
      Console.WriteLine("{0} rapidamente se cura", hor.getNome()); 
      hor.AumentarVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", hor.getPtsVida()); 
      
      Console.WriteLine("{0} sem perder tempo lança uma magia", hor.getNome()); 
      hor.LancarMagia();
      Console.WriteLine("{0} logo em seguida desfere um golpe com sua arma", hor.getNome()); 
      hor.AtacarComArma();
      
      Console.WriteLine("\ne a batalha continua...");       
      
      //3, 4, 5 
      /*
      //Heroi padrão
      Heroi heroi1 = new Heroi("Zymmax", 100);
      Console.WriteLine("Heroi Padrão"); 
      
      Console.WriteLine("O nome do heroi é: {0}", heroi1.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", heroi1.getNome(), heroi1.getPtsVida()); 
      Console.WriteLine("{0} sofreu um ataque", heroi1.getNome()); 
      heroi1.ReduzirVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", heroi1.getPtsVida()); 
      
      Console.WriteLine("{0} rapidamente se cura", heroi1.getNome()); 
      heroi1.AumentarVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", heroi1.getPtsVida());*/
      
      //8, 9, 10
      /*
      //heroi Aliança
      Console.WriteLine("\nHeroi Aliança"); 
      HeroiAlianca heroi2 = new HeroiAlianca("Zadur", 100);
      Console.WriteLine("O nome do heroi é: {0}", heroi2.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", heroi2.getNome(), heroi2.getPtsVida()); 
      
      Console.WriteLine("{0} sofreu um ataque", heroi2.getNome()); 
      heroi2.ReduzirVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", heroi2.getPtsVida()); 
      
      Console.WriteLine("{0} rapidamente se cura", heroi2.getNome()); 
      heroi2.AumentarVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", heroi2.getPtsVida());*/
      
      //13, 14, 15
      //heroi Horda
      /*Console.WriteLine("\nHeroi Horda"); 
      HeroiHorda heroi3 = new HeroiHorda("Zodar", 100);
      Console.WriteLine("O nome do heroi é: {0}", heroi3.getNome());
      Console.WriteLine("Os pontos de vida de {0} são: {1}", heroi3.getNome(), heroi3.getPtsVida()); 
      
      Console.WriteLine("{0} sofreu um ataque", heroi3.getNome()); 
      heroi3.ReduzirVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", heroi3.getPtsVida()); 
      
      Console.WriteLine("{0} rapidamente se cura", heroi3.getNome()); 
      heroi3.AumentarVida();
      Console.WriteLine("seus pontos de vida agr são: {0}", heroi3.getPtsVida()); */
      

   }//main

 }//UoU

}//Uordi_ofi_Uorcrefiti
