namespace CovidX.Models
{
    interface IEvidencijaSimptoma
    {

        public bool otezanoDisanjeIliNedostatakDaha { get; set; } //10
        public bool bolUGrudima { get; set; } //5
        public bool gubitakGovoraIliPokreta { get; set; } //2
        public bool povisenaTemperatura { get; set; }//20
        public bool suhiKasalj { get; set; } //15
        public bool umor { get; set; } //10
        public bool glavobolja { get; set; } //5
        public bool gubitakOkusaIliMirisa { get; set; } //30
        public bool osipNaKozi { get; set; } //3
        public static bool evidentirajSimptome(bool s1, bool s2, bool s3, bool s4, bool s5, bool s6, bool s7, bool s8, bool s9)
        {
            var broj = 0;
            if (s1 == true) broj += 10;
            if (s2 == true) broj += 5;
            if (s3 == true) broj += 2;
            if (s4 == true) broj += 20;
            if (s5 == true) broj += 15;
            if (s6 == true) broj += 10;
            if (s7 == true) broj += 5;
            if (s8 == true) broj += 30;
            if (s9 == true) broj += 3;
            if (broj >= 35)
                return true;
            return false;

        }
    }
}
