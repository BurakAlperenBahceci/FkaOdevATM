public abstract class ATM
{
    public abstract void ParaYatırma(int miktar);
    public abstract void ParaÇekme(int miktar);
    public abstract void BakiyeSorgulama();
}
public class NakitATM : ATM
{
    private int bakiye = 1000;

    public override void ParaYatırma(int miktar)
    {
        bakiye += miktar;
        Console.WriteLine("Hesabınıza {0} TL yatırıldı.", miktar);
    }
    public override void ParaÇekme(int miktar)
    {
        if (bakiye < miktar)
        {
            Console.WriteLine("Hesap bakiyesi yetersiz.");
            return;
        }

        bakiye -= miktar;
        Console.WriteLine("Hesabınızdan {0} TL çekildi.", miktar);
    }

    public override void BakiyeSorgulama()
    {
        Console.WriteLine("Hesap bakiyeniz {0} TL'dir.", bakiye);
    }
}
public class MainClass
{
    public static void Main(string[] args)
    {

        NakitATM nakitATM = new NakitATM();


        nakitATM.ParaYatırma(100);


        nakitATM.ParaÇekme(50);


        nakitATM.BakiyeSorgulama();
    }
}