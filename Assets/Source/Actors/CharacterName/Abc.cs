using Assets.Source.Core;
using DungeonCrawl.Actors;
using DungeonCrawl.Actors.Characters;

namespace Assets.Source.Actors.CharacterName
{
    public class Char : Actor
    {
        protected override int DefaultSpriteId { get; }
        public override string DefaultName { get; set; }

        protected override bool OnCollision(Actor anotherActor)
        {
            UserInterface.Singleton.SetText("Press Enter to select", UserInterface.TextPosition.BottomRight);
            return true;
        }
    }
    public class Enter : Char
    {
        public override string DefaultName
        {
            get => "!";
            set { }
        }

        protected override int DefaultSpriteId => 981;
    }
    public class BackSpace : Char
    {
        public override string DefaultName
        {
            get => "<";
            set { }
        }

        protected override int DefaultSpriteId => 990;
    }
    public class Empty : Char
    {
        public override string DefaultName
        {
            get => " ";
            set { }
        }

        protected override int DefaultSpriteId => 1029;
    }
    public class Hyphen : Char
    {
        public override string DefaultName
        {
            get => "-";
            set { }
        }

        protected override int DefaultSpriteId => 996;
    }
    public class Zero : Char
    {
        public override string DefaultName
        {
            get => "0";
            set { }
        }

        protected override int DefaultSpriteId => 850;
    }
    public class One : Char
    {
        public override string DefaultName
        {
            get => "1";
            set { }
        }

        protected override int DefaultSpriteId => 851;
    }
    public class Two : Char
    {
        public override string DefaultName
        {
            get => "2";
            set { }
        }

        protected override int DefaultSpriteId => 852;
    }
    public class Three : Char
    {
        public override string DefaultName
        {
            get => "3";
            set { }
        }

        protected override int DefaultSpriteId => 853;
    }
    public class Four : Char
    {
        public override string DefaultName
        {
            get => "4";
            set { }
        }

        protected override int DefaultSpriteId => 854;
    }
    public class Five : Char
    {
        public override string DefaultName
        {
            get => "5";
            set { }
        }

        protected override int DefaultSpriteId => 855;
    }
    public class Six : Char
    {
        public override string DefaultName
        {
            get => "6";
            set { }
        }

        protected override int DefaultSpriteId => 856;
    }
    public class Seven : Char
    {
        public override string DefaultName
        {
            get => "7";
            set { }
        }

        protected override int DefaultSpriteId => 857;
    }
    public class Eight : Char
    {
        public override string DefaultName
        {
            get => "8";
            set { }
        }

        protected override int DefaultSpriteId => 858;
    }
    public class Nine : Char
    {
        public override string DefaultName
        {
            get => "9";
            set { }
        }

        protected override int DefaultSpriteId => 859;
    }
    public class A : Char
    {
        public override string DefaultName
        {
            get => "A";
            set { }
        }

        protected override int DefaultSpriteId => 898;
    }
    public class B : Char
    {
        public override string DefaultName
        {
            get => "B";
            set { }
        }

        protected override int DefaultSpriteId => 899;
    }
    public class C : Char
    {
        public override string DefaultName
        {
            get => "C";
            set { }
        }

        protected override int DefaultSpriteId => 900;
    }
    public class D : Char
    {
        public override string DefaultName
        {
            get => "D";
            set { }
        }

        protected override int DefaultSpriteId => 901;
    }
    public class E : Char
    {
        public override string DefaultName
        {
            get => "E";
            set { }
        }

        protected override int DefaultSpriteId => 902;
    }
    public class F : Char
    {
        public override string DefaultName
        {
            get => "F";
            set { }
        }

        protected override int DefaultSpriteId => 903;
    }
    public class G : Char
    {
        public override string DefaultName
        {
            get => "G";
            set { }
        }

        protected override int DefaultSpriteId => 904;
    }
    public class H : Char
    {
        public override string DefaultName
        {
            get => "H";
            set { }
        }

        protected override int DefaultSpriteId => 905;
    }
    public class I : Char
    {
        public override string DefaultName
        {
            get => "I";
            set { }
        }

        protected override int DefaultSpriteId => 906;
    }
    public class J : Char
    {
        public override string DefaultName
        {
            get => "J";
            set { }
        }

        protected override int DefaultSpriteId => 907;
    }
    public class K : Char
    {
        public override string DefaultName
        {
            get => "K";
            set { }
        }

        protected override int DefaultSpriteId => 908;
    }
    public class L : Char
    {
        public override string DefaultName
        {
            get => "L";
            set { }
        }

        protected override int DefaultSpriteId => 909;
    }
    public class M : Char
    {
        public override string DefaultName
        {
            get => "M";
            set { }
        }

        protected override int DefaultSpriteId => 910;
    }
    public class N : Char
    {
        public override string DefaultName
        {
            get => "N";
            set { }
        }

        protected override int DefaultSpriteId => 946;
    }
    public class O : Char
    {
        public override string DefaultName
        {
            get => "O";
            set { }
        }

        protected override int DefaultSpriteId => 947;
    }
    public class P : Char
    {
        public override string DefaultName
        {
            get => "P";
            set { }
        }

        protected override int DefaultSpriteId => 948;
    }
    public class Q : Char
    {
        public override string DefaultName
        {
            get => "Q";
            set { }
        }

        protected override int DefaultSpriteId => 949;
    }
    public class R : Char
    {
        public override string DefaultName
        {
            get => "R";
            set { }
        }

        protected override int DefaultSpriteId => 950;
    }
    public class S : Char
    {
        public override string DefaultName
        {
            get => "S";
            set { }
        }

        protected override int DefaultSpriteId => 951;
    }
    public class T : Char
    {
        public override string DefaultName
        {
            get => "T";
            set { }
        }

        protected override int DefaultSpriteId => 952;
    }
    public class U : Char
    {
        public override string DefaultName
        {
            get => "U";
            set { }
        }

        protected override int DefaultSpriteId => 953;
    }
    public class V : Char
    {
        public override string DefaultName
        {
            get => "V";
            set { }
        }

        protected override int DefaultSpriteId => 954;
    }
    public class W : Char
    {
        public override string DefaultName
        {
            get => "W";
            set { }
        }

        protected override int DefaultSpriteId => 955;
    }
    public class X : Char
    {
        public override string DefaultName
        {
            get => "X";
            set { }
        }

        protected override int DefaultSpriteId => 956;
    }
    public class Y : Char
    {
        public override string DefaultName
        {
            get => "Y";
            set { }
        }

        protected override int DefaultSpriteId => 957;
    }
    public class Z : Char
    {
        public override string DefaultName
        {
            get => "Z";
            set { }
        }

        protected override int DefaultSpriteId => 958;
    }

}
