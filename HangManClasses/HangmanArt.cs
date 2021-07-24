using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangManClasses
{
    public class HangmanArt
    {
        public string EmptyNoose { get; }
        public string Head { get; }
        public string Body { get; }
        public string LeftArm { get; }
        public string RightArm { get; }
        public string LeftLeg { get; }
        public string RightLeg { get; }

        public HangmanArt()
        {
            EmptyNoose =
                "      _____________\n" +
                "     |             |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "   ------";

            Head =
                "      _____________\n" +
                "     |             |\n" +
                "     |           _____\n" +
                "     |          /     \\ \n" +
                "     |          |     |\n" +
                "     |          \\_____/\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "   ------";

            Body =
                "      _____________\n" +
                "     |             |\n" +
                "     |           _____\n" +
                "     |          /     \\ \n" +
                "     |          |     |\n" +
                "     |          \\_____/\n" +
                "     |             |\n" +
                "     |             |\n" +
                "     |             |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "   ------";

            LeftArm =
                "      _____________\n" +
                "     |             |\n" +
                "     |           _____\n" +
                "     |          /     \\ \n" +
                "     |          |     |\n" +
                "     |          \\_____/\n" +
                "     |           \\ |\n" +
                "     |            \\|\n" +
                "     |             |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "   ------";

            RightArm =
                "      _____________\n" +
                "     |             |\n" +
                "     |           _____\n" +
                "     |          /     \\ \n" +
                "     |          |     |\n" +
                "     |          \\_____/\n" +
                "     |           \\ | /\n" +
                "     |            \\|/\n" +
                "     |             |\n" +
                "     |\n" +
                "     |\n" +
                "     |\n" +
                "   ------";

            LeftLeg =
                "      _____________\n" +
                "     |             |\n" +
                "     |           _____\n" +
                "     |          /     \\ \n" +
                "     |          |     |\n" +
                "     |          \\_____/\n" +
                "     |           \\ | /\n" +
                "     |            \\|/\n" +
                "     |             |\n" +
                "     |            / \n" +
                "     |           /  \n" +
                "     |          /   \n" +
                "   ------";

            RightLeg =
                "      _____________\n" +
                "     |             |\n" +
                "     |           _____\n" +
                "     |          /     \\ \n" +
                "     |          |     |\n" +
                "     |          \\_____/\n" +
                "     |           \\ | /\n" +
                "     |            \\|/\n" +
                "     |             |\n" +
                "     |            / \\ \n" +
                "     |           /   \\ \n" +
                "     |          /     \\ \n" +
                "   ------";
        }

    }
}
