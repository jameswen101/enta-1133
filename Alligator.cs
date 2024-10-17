using System;

public class Alligator : Enemy
{
    public Alligator(String name) : base(name)
    {
        this.name = name;
        asciiArt = "           _  _\r\n             / \\/ \\-._   _.-'^'^^'^^'^^\"^^'-.\r\n    .OO.----'\\o/\\o/   `-'                /^  ^^-._\r\n   (    `                 \\             |    _    ^^-._\r\n    VvvvvvvVvv`___...)_/  /_/_/_/_/_/_/_/\\  (__________^^-.\r\njgs  `^^^^^^^^`       /  /                >  >        _`)  )\r\n                     (((`                (((`        `'--'^";
        //show ASCII art of the alligator
    }
}
