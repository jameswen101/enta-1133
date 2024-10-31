﻿using System;

public class Wolf : Enemy
{
    public Wolf(String name) : base(name)
    {
        this.name = name;
        asciiArt = "     _                  _\r\n    | '-.            .-' |\r\n    | -. '..\\\\,.//,.' .- |\r\n    |   \\  \\\\\\||///  /   |\r\n   /|    )M\\/%%%%/\\/(  . |\\\r\n  (/\\  MM\\/%/\\||/%\\\\/MM  /\\)\r\n  (//M   \\%\\\\\\%%//%//   M\\\\)\r\n(// M________ /\\ ________M \\\\)\r\n (// M\\ \\(',)|  |(',)/ /M \\\\) \\\\\\\\  \r\n  (\\\\ M\\.  /,\\\\//,\\  ./M //)\r\n    / MMmm( \\\\||// )mmMM \\  \\\\\r\n     // MMM\\\\\\||///MMM \\\\ \\\\\r\n      \\//''\\)/||\\(/''\\\\/ \\\\\r\n      mrf\\\\( \\oo/ )\\\\\\/\\\r\n           \\'-..-'\\/\\\\\r\n              \\\\/ \\\\";
        //show ASCII art of the wolf
    }
}
