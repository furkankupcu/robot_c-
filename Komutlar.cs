using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2mfk
{
    class Komutlar
    {

    }
     public class Yürütme : IKomutlar
    {
        Robot robot;

        public void RobotYürütme(Robot robot)
        {
            this.robot = robot;
        }
        public void Yürüt()
        {
            robot.Yürü();

        }
    }

    public class Durdurma : IKomutlar
    {
        Robot robot;

        public void RobotDurdurma(Robot robot)
        {
            this.robot = robot;
        }
        public void Yürüt()
        {
            robot.Dur();

        }
    }
    public class Çalıştırma : IKomutlar
    {
        Robot robot;

        public void RobotÇalıştırma(Robot robot)
        {
            this.robot = robot;
        }
        public void Yürüt()
        {
            robot.Çalıştır();

        }
    }

    public class SağaDöndürme : IKomutlar
    {
        Robot robot;

        public void RobotSağaDöndürme(Robot robot)
        {
            this.robot = robot;
        }
        public void Yürüt()
        {
            robot.SağaDön();

        }
    }
    public class SolaDöndürme : IKomutlar
    {
        Robot robot;

        public void RobotSolaDöndürme(Robot robot)
        {
            this.robot = robot;
        }
        public void Yürüt()
        {
            robot.SolaDön();

        }
    }

    public class Kapatma : IKomutlar
    {
        Robot robot;

        public void RobotKapatma(Robot robot)
        {
            this.robot = robot;
        }
        public void Yürüt()
        {
            robot.Kapat();

        }
    }

    public class KomutYok: IKomutlar
    {
        public void Yürüt()
        {

        }
    }

















}
