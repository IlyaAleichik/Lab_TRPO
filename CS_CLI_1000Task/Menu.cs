using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Less_6
{
    class Menu
    {
        public void f_GenerationText() {

            for (int i = 1; i < 201; i++)
            {
                Console.WriteLine("{0}. Lesson_{1}", i, i);

            }

        }
        public void Exit()
        {
            Program pr = new Program();
            char n = 'y';
            Console.WriteLine("Вернуться в меню  y/n");
            n = Convert.ToChar(Console.ReadLine());
            Console.Clear();
            if (n == 'y')
            {

                f_Menu();

            }
            else { }
        }

        public void f_Menu()
        {

            ClassFunc classfunc = new ClassFunc();
            f_GenerationText();
            try
            {
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {

                    case 1:
                        Console.Clear();
                        classfunc.Lesson_1();
                       
                        break;
                    case 2:
                        Console.Clear();
                        classfunc.Lesson_2();
                        break;
                    case 3:
                        Console.Clear();
                        classfunc.Lesson_3();
                        break;
                    case 4:
                        Console.Clear();
                        classfunc.Lesson_4();
                        break;
                    case 5:
                        Console.Clear();
                        classfunc.Lesson_5();
                        break;
                    case 6:
                        Console.Clear();
                        classfunc.Lesson_6();
                        break;
                    case 7:
                        Console.Clear();
                        classfunc.Lesson_7();
                        break;
                    case 8:
                        Console.Clear();
                        classfunc.Lesson_8();
                        break;
                    case 9:
                        Console.Clear();
                        classfunc.Lesson_9();
                        break;
                    case 10:
                        Console.Clear();
                        classfunc.Lesson_10();
                        break;
                    case 11:
                        Console.Clear();
                        classfunc.Lesson_11();
                        break;
                    case 12:
                        Console.Clear();
                        classfunc.Lesson_12();
                        break;
                    case 13:
                        classfunc.Lesson_13();
                        break;
                    case 14:
                        Console.Clear();
                        classfunc.Lesson_14();
                        break;
                    case 15:
                        Console.Clear();
                        classfunc.Lesson_15();
                        break;
                    case 16:
                        Console.Clear();
                        classfunc.Lesson_16();
                        break;
                    case 17:
                        Console.Clear();
                        classfunc.Lesson_17();
                        break;
                    case 18:
                        Console.Clear();
                        classfunc.Lesson_18();
                        break;
                    case 19:
                        Console.Clear();
                        classfunc.Lesson_19();
                        break;
                    case 20:
                        Console.Clear();
                        classfunc.Lesson_20();
                        break;
                    case 21:
                        Console.Clear();
                        classfunc.Lesson_21();
                        break;
                    case 22:
                        Console.Clear();
                        classfunc.Lesson_22();
                        break;
                    case 23:
                        Console.Clear();
                        classfunc.Lesson_23();
                        break;
                    case 24:
                        Console.Clear();
                        classfunc.Lesson_24();
                        break;
                    case 25:
                        Console.Clear();
                        classfunc.Lesson_25();
                        break;
                    case 26:
                        Console.Clear();
                        classfunc.Lesson_26();
                        break;
                    case 27:
                        Console.Clear();
                        classfunc.Lesson_27();
                        break;
                    case 28:
                        Console.Clear();
                        classfunc.Lesson_28();
                        break;
                    case 29:
                        Console.Clear();
                        classfunc.Lesson_29();
                        break;
                    case 30:
                        Console.Clear();
                        classfunc.Lesson_30();
                        break;
                    case 31:
                        Console.Clear();
                        classfunc.Lesson_31();
                        break;
                    case 32:
                        Console.Clear();
                        classfunc.Lesson_32();
                        break;
                    case 33:
                        Console.Clear();
                        classfunc.Lesson_33();
                        break;
                    case 34:
                        Console.Clear();
                        classfunc.Lesson_34();
                        break;
                    case 35:
                        Console.Clear();
                        classfunc.Lesson_35();
                        break;
                    case 36:
                        Console.Clear();
                        classfunc.Lesson_36();
                        break;
                    case 37:
                        Console.Clear();
                        classfunc.Lesson_37();
                        break;
                    case 38:
                        Console.Clear();
                        classfunc.Lesson_38();
                        break;
                    case 39:
                        Console.Clear();
                        classfunc.Lesson_39();
                        break;
                    case 40:
                        Console.Clear();
                        classfunc.Lesson_40();
                        break;
                    case 41:
                        Console.Clear();
                        classfunc.Lesson_41();
                        break;
                    case 42:
                        Console.Clear();
                        classfunc.Lesson_42();
                        break;
                    case 43:
                        Console.Clear();
                        classfunc.Lesson_43();
                        break;
                    case 44:
                        Console.Clear();
                        classfunc.Lesson_44();
                        break;
                    case 45:
                        Console.Clear();
                        classfunc.Lesson_45();
                        break;
                    case 46:
                        Console.Clear();
                        classfunc.Lesson_46();
                        break;
                    case 47:
                        Console.Clear();
                        classfunc.Lesson_47();
                        break;
                    case 48:
                        Console.Clear();
                        classfunc.Lesson_48();
                        break;
                    case 49:
                        Console.Clear();
                        classfunc.Lesson_49();
                        break;
                    case 50:
                        Console.Clear();
                        classfunc.Lesson_50();
                        break;
                    case 51:
                        Console.Clear();
                        classfunc.Lesson_51();
                        break;
                    case 52:
                        Console.Clear();
                        classfunc.Lesson_52();
                        break;
                    case 53:
                        Console.Clear();
                        classfunc.Lesson_53();
                        break;
                    case 54:
                        Console.Clear();
                        classfunc.Lesson_54();
                        break;
                    case 55:
                        Console.Clear();
                        classfunc.Lesson_55();
                        break;
                    case 56:
                        Console.Clear();
                        classfunc.Lesson_56();
                        break;
                    case 57:
                        Console.Clear();
                        classfunc.Lesson_57();
                        break;
                    case 58:
                        Console.Clear();
                        classfunc.Lesson_58();
                        break;
                    case 59:
                        Console.Clear();
                        classfunc.Lesson_59();
                        break;
                    case 60:
                        Console.Clear();
                        classfunc.Lesson_60();
                        break;
                    case 61:
                        Console.Clear();
                        classfunc.Lesson_61();
                        break;
                    case 62:
                        Console.Clear();
                        classfunc.Lesson_62();
                        break;
                    case 63:
                        Console.Clear();
                        classfunc.Lesson_63();
                        break;
                    case 64:
                        Console.Clear();
                        classfunc.Lesson_64();
                        break;
                    case 65:
                        Console.Clear();
                        classfunc.Lesson_65();
                        break;
                    case 66:
                        Console.Clear();
                        classfunc.Lesson_66();
                        break;
                    case 67:
                        Console.Clear();
                        classfunc.Lesson_67();
                        break;
                    case 68:
                        Console.Clear();
                        classfunc.Lesson_68();
                        break;
                    case 69:
                        Console.Clear();
                        classfunc.Lesson_69();
                        break;
                    case 70:
                        Console.Clear();
                        classfunc.Lesson_70();
                        break;
                    case 71:
                        Console.Clear();
                        classfunc.Lesson_71();
                        break;
                    case 72:
                        Console.Clear();
                        classfunc.Lesson_72();
                        break;
                    case 73:
                        Console.Clear();
                        classfunc.Lesson_73();
                        break;
                    case 74:
                        Console.Clear();
                        classfunc.Lesson_74();
                        break;
                    case 75:
                        Console.Clear();
                        classfunc.Lesson_75();
                        break;
                    case 76:
                        Console.Clear();
                        classfunc.Lesson_76();
                        break;
                    case 77:
                        Console.Clear();
                        classfunc.Lesson_77();
                        break;
                    case 78:
                        Console.Clear();
                        classfunc.Lesson_78();
                        break;
                    case 79:
                        Console.Clear();
                        classfunc.Lesson_79();
                        break;
                    case 80:
                        Console.Clear();
                        classfunc.Lesson_80();
                        break;
                    case 81:
                        Console.Clear();
                        classfunc.Lesson_81();
                        break;
                    case 82:
                        Console.Clear();
                        classfunc.Lesson_82();
                        break;
                    case 83:
                        Console.Clear();
                        classfunc.Lesson_83();
                        break;
                    case 84:
                        Console.Clear();
                        classfunc.Lesson_84();
                        break;
                    case 85:
                        Console.Clear();
                        classfunc.Lesson_85();
                        break;
                    case 86:
                        Console.Clear();
                        classfunc.Lesson_86();
                        break;
                    case 87:
                        Console.Clear();
                        classfunc.Lesson_87();
                        break;
                    case 88:
                        Console.Clear();
                        classfunc.Lesson_88();
                        break;
                    case 89:
                        Console.Clear();
                        classfunc.Lesson_89();
                        break;
                    case 90:
                        Console.Clear();
                        classfunc.Lesson_90();
                        break;
                    case 91:
                        Console.Clear();
                        classfunc.Lesson_91();
                        break;
                    case 92:
                        Console.Clear();
                        classfunc.Lesson_92();
                        break;
                    case 93:
                        Console.Clear();
                        classfunc.Lesson_93();
                        break;
                    case 94: Console.Clear();
                        classfunc.Lesson_94();
                        break;
                    case 95:
                        Console.Clear();
                        classfunc.Lesson_95();
                        break;
                    case 96:
                        Console.Clear();
                        classfunc.Lesson_96();
                        break;
                    case 97:
                        Console.Clear();
                        classfunc.Lesson_97();
                        break;
                    case 98:
                        Console.Clear();
                        classfunc.Lesson_98();
                        break;
                    case 99:
                        Console.Clear();
                        classfunc.Lesson_99();
                        break;
                    case 100:
                        Console.Clear();
                        classfunc.Lesson_100();
                        break;

                    case 101:
                        Console.Clear();
                        classfunc.Lesson_101();
                        break;

                    case 102:
                        Console.Clear();
                        classfunc.Lesson_102();
                        break;

                    case 103:
                        Console.Clear();
                        classfunc.Lesson_103();
                        break;

                    case 104:
                        Console.Clear();
                        classfunc.Lesson_104();
                        break;

                    case 105:
                        Console.Clear();
                        classfunc.Lesson_105();
                        break;

                    case 106:
                        Console.Clear();
                        classfunc.Lesson_106();
                        break;

                    case 107:
                        Console.Clear();
                        classfunc.Lesson_107();
                        break;

                    case 108:
                        Console.Clear();
                        classfunc.Lesson_108();
                        break;

                    case 109:
                        Console.Clear();
                        classfunc.Lesson_109();
                        break;

                    case 110:
                        Console.Clear();
                        classfunc.Lesson_110();
                        break;

                    case 111:
                        Console.Clear();
                        classfunc.Lesson_111();
                        break;

                    case 112:
                        Console.Clear();
                        classfunc.Lesson_112();
                        break;

                    case 113:
                        Console.Clear();
                        classfunc.Lesson_113();
                        break;

                    case 114:
                        Console.Clear();
                        classfunc.Lesson_114();
                        break;

                    case 115:
                        Console.Clear();
                        classfunc.Lesson_115();
                        break;

                    case 116:
                        Console.Clear();
                        classfunc.Lesson_116();
                        break;

                    case 117:
                        Console.Clear();
                        classfunc.Lesson_117();
                        break;

                    case 118:
                        Console.Clear();
                        classfunc.Lesson_118();
                        break;

                    case 119:
                        Console.Clear();
                        classfunc.Lesson_119();
                        break;

                    case 120:
                        Console.Clear();
                        classfunc.Lesson_120();
                        break;
                    case 121:
                        Console.Clear();
                        classfunc.Lesson_121();
                        break;
                    case 122:
                        Console.Clear();
                        classfunc.Lesson_122();
                        break;
                    case 123:
                        Console.Clear();
                        classfunc.Lesson_123();
                        break;
                    case 124:
                        Console.Clear();
                        classfunc.Lesson_124();
                        break;
                    case 125:
                        Console.Clear();
                        classfunc.Lesson_125();
                        break;
                    case 126:
                        Console.Clear();
                        classfunc.Lesson_126();
                        break;
                    case 127:
                        Console.Clear();
                        classfunc.Lesson_127();
                        break;
                    case 128:
                        Console.Clear();
                        classfunc.Lesson_128();
                        break;
                    case 129:
                        Console.Clear();
                        classfunc.Lesson_129();
                        break;
                    case 130:
                        Console.Clear();
                        classfunc.Lesson_130();
                        break;
                    case 131:
                        Console.Clear();
                        classfunc.Lesson_131();
                        break;
                    case 132:
                        Console.Clear();
                        classfunc.Lesson_132();
                        break;
                    case 133:
                        Console.Clear();
                        classfunc.Lesson_133();
                        break;
                    case 134:
                        Console.Clear();
                        classfunc.Lesson_134();
                        break;
                    case 135:
                        Console.Clear();
                        classfunc.Lesson_135();
                        break;
                    case 136:
                        Console.Clear();
                        classfunc.Lesson_136();
                        break;
                    case 137:
                        Console.Clear();
                        classfunc.Lesson_137();
                        break;
                    case 138:
                        Console.Clear();
                        classfunc.Lesson_138();
                        break;
                    case 139:
                        Console.Clear();
                        classfunc.Lesson_139();
                        break;
                    case 140:
                        Console.Clear();
                        classfunc.Lesson_140();
                        break;
                    case 141:
                        Console.Clear();
                        classfunc.Lesson_141();
                        break;
                    case 142:
                        Console.Clear();
                        classfunc.Lesson_142();
                        break;
                    case 143:
                        Console.Clear();
                        classfunc.Lesson_143();
                        break;
                    case 144:
                        Console.Clear();
                        classfunc.Lesson_144();
                        break;
                    case 145:
                        Console.Clear();
                        classfunc.Lesson_145();
                        break;
                    case 146:
                        Console.Clear();
                        classfunc.Lesson_146();
                        break;
                    case 147:
                        Console.Clear();
                        classfunc.Lesson_147();
                        break;
                    case 148:
                        Console.Clear();
                        classfunc.Lesson_148();
                        break;
                    case 149:
                        Console.Clear();
                        classfunc.Lesson_149();
                        break;
                    case 150:
                        Console.Clear();
                        classfunc.Lesson_150();
                        break;
                    case 151:
                        Console.Clear();
                        classfunc.Lesson_151();
                        break;
                    case 152:
                        Console.Clear();
                        classfunc.Lesson_152();
                        break;
                    case 153:
                        Console.Clear();
                        classfunc.Lesson_153();
                        break;
                    case 154:
                        Console.Clear();
                        classfunc.Lesson_154();
                        break;
                    case 155:
                        Console.Clear();
                        classfunc.Lesson_155();
                        break;
                    case 156:
                        Console.Clear();
                        classfunc.Lesson_156();
                        break;
                    case 157:
                        Console.Clear();
                        classfunc.Lesson_157();
                        break;
                    case 158:
                        Console.Clear();
                        classfunc.Lesson_158();
                        break;
                    case 159:
                        Console.Clear();
                        classfunc.Lesson_159();
                        break;
                    case 160:
                        Console.Clear();
                        classfunc.Lesson_160();
                        break;
                    case 161:
                        Console.Clear();
                        classfunc.Lesson_161();
                        break;
                    case 162:
                        Console.Clear();
                        classfunc.Lesson_162();
                        break;
                    case 163:
                        Console.Clear();
                        classfunc.Lesson_163();
                        break;
                    case 164:
                        Console.Clear();
                        classfunc.Lesson_164();
                        break;
                    case 165:
                        Console.Clear();
                        classfunc.Lesson_165();
                        break;
                    case 166:
                        Console.Clear();
                        classfunc.Lesson_166();
                        break;
                    case 167:
                        Console.Clear();
                        classfunc.Lesson_167();
                        break;
                    case 168:
                        Console.Clear();
                        classfunc.Lesson_168();
                        break;
                    case 169:
                        Console.Clear();
                        classfunc.Lesson_169();
                        break;
                    case 170:
                        Console.Clear();
                        classfunc.Lesson_170();
                        break;
                    case 171:
                        Console.Clear();
                        classfunc.Lesson_171();
                        break;
                    case 172:
                        Console.Clear();
                        classfunc.Lesson_172();
                        break;
                    case 173:
                        Console.Clear();
                        classfunc.Lesson_173();
                        break;
                    case 174:
                        Console.Clear();
                        classfunc.Lesson_174();
                        break;
                    case 175:
                        Console.Clear();
                        classfunc.Lesson_175();
                        break;
                    case 176:
                        Console.Clear();
                        classfunc.Lesson_176();
                        break;
                    case 177:
                        Console.Clear();
                        classfunc.Lesson_177();
                        break;
                    case 178:
                        Console.Clear();
                        classfunc.Lesson_178();
                        break;
                    case 179:
                        Console.Clear();
                        classfunc.Lesson_179();
                        break;
                    case 180:
                        Console.Clear();
                        classfunc.Lesson_180();
                        break;
                    case 181:
                        Console.Clear();
                        classfunc.Lesson_181();
                        break;
                    case 182:
                        Console.Clear();
                        classfunc.Lesson_182();
                        break;
                    case 183:
                        Console.Clear();
                        classfunc.Lesson_183();
                        break;
                    case 184:
                        Console.Clear();
                        classfunc.Lesson_184();
                        break;
                    case 185:
                        Console.Clear();
                        classfunc.Lesson_185();
                        break;
                    case 186:
                        Console.Clear();
                        classfunc.Lesson_186();
                        break;
                    case 187:
                        Console.Clear();
                        classfunc.Lesson_187();
                        break;
                    case 188:
                        Console.Clear();
                        classfunc.Lesson_188();
                        break;
                    case 189:
                        Console.Clear();
                        classfunc.Lesson_189();
                        break;
                    case 190:
                        Console.Clear();
                        classfunc.Lesson_190();
                        break;
                    case 191:
                        Console.Clear();
                        classfunc.Lesson_191();
                        break;
                    case 192:
                        Console.Clear();
                        classfunc.Lesson_192();
                        break;
                    case 193:
                        Console.Clear();
                        classfunc.Lesson_193();
                        break;
                    case 194:
                        Console.Clear();
                        classfunc.Lesson_194();
                        break;
                    case 195:
                        Console.Clear();
                        classfunc.Lesson_195();
                        break;
                    case 196:
                        Console.Clear();
                        classfunc.Lesson_196();
                        break;
                    case 197:
                        Console.Clear();
                        classfunc.Lesson_197();
                        break;
                    case 198:
                        Console.Clear();
                        classfunc.Lesson_198();
                        break;
                    case 199:
                        Console.Clear();
                        classfunc.Lesson_199();
                        break;
                    case 200:
                        Console.Clear();
                        classfunc.Lesson_200();
                        break;

                }
            }
            catch { Console.ReadKey(); }
        }
    }
}
