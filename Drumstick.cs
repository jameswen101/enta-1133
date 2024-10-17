﻿using System;

public class Drumstick : Meat
{
    public Drumstick(String meatName, int healthBoost) : base(meatName, healthBoost)
    {
        this.meatName = meatName;
        this.healthBoost = healthBoost;
        description = $"Boost your health by {healthBoost} points";
        asciiArt = "                                                                                                    \r\n                                                                                                    \r\n                                                                                                    \r\n                  ......................                                                            \r\n                ..:##=......-=+++==+*#%@*:..                                                        \r\n              .+#=...:=*#**######****##+:.-*#+:.                                                    \r\n          ..:*+..:**-..-====::.::=+++=:.:=#*-..=#*-...                                              \r\n         ..#+...=..:*+.................=*-...=-. ..*#-..                                            \r\n        .=@:...    ....:....:=+-...+%=.......    .*-..+@-.                                          \r\n      .-@@-.*:..       ..:::::+#-.. ....         ..:#=#*::#%=.....                                  \r\n     .=*#%.*-.-.         ..===#=.:.                 .-**+*#*--=+##*+-...                            \r\n     .%:##.#..#.      ..      ....       .......      ...*%*==**##%%@@@@#=-.................        \r\n     -#.+@.-#.*-.     .*:.:.. .=%-. .:.. .-+:=..            ..+#%%%%%#:*%=.:*#%%%#-..:#+*%#-....    \r\n    .-#..%*..#**#..   ..::::.       :%#.  ....                        .......... ..**.==...%:#+.    \r\n  .*#-#-..+%-..+#-..    .*-.--. ...   ..*-::....    -:..    :+...         .-..#.....#.:%*+.#::%.    \r\n  .*+.+-....-%*-..      :%-=%:  -+... ..**#:..#:*...*+..    :+=:.+..      ..*:-=:+..=*%:..#@:**.    \r\n  .-%.+:..++...+@#..     .......%..#.     ....:#-.  ..      .*-+.#.:#....   -:.*.#....-+..#%@%..    \r\n    #+%:.:%@@#:..=@-  ..:.. ... +@@+.      =+.     .=.   ....:+=+:#.+:.#.......+.*:.   ..+#:%:      \r\n    :%#..-##***...%%..  .**.%*#.    .*.   .=*:+.  .::...-#=. .:.=:.*.#:-*.=-..::.=..   .-#.-%:      \r\n    .=#..+*=......@+..-+.+-+...     -+..++......     .-*::+*...=:.....-.:+... ..... .+=.-*.:%:      \r\n     .*-.*=......*@-  .#.=+%..      :#:.*-.  .*--:.. ...*-.-**:.-*@@@@@@+-:-==-:#+--=%-.:%:#*.      \r\n      .**..*%#**.*@+...#:*+%......  ......  ..=@%*.......##::#@@%:.....-%@@*...*@@#-...=@@*...      \r\n        .*#:......%@*....=#.....+..           .....=*--%*.*@%-...               ..........          \r\n         .:%@#=.  .*@@+. .+=**. .#%-....      ...#=.+%==#+..                                        \r\n          ..%::#*....#@- ..+#+#:.........:..:=#*=.-+.=%-..                                          \r\n            -#.......-@-. .-%%%*=.     ...::::+....*%-..                                            \r\n            .#*.:#@#*:@-..#=-=...       .=@#:...-%#...                                              \r\n             .*+.=%=..=#...**:==+#....-*#:...-#%=...                                                \r\n              .+%:.-:..+@-..=##*:.::::...:+%%+..                                                    \r\n                .+#--+=..*@*:.......:-*@@%+.                                                        \r\n                   .=%@@@@@@@@@@@@@@@*:....                                                         \r\n                          ............                                                              \r\n                                                                                                    \r\n                                                                                                    \r\n                                                                                                    ";
        //shows a chicken drumstick
    }
}

