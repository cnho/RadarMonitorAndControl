namespace DataCurveDisplay
{
    public static class DataEnum2Titles
    {
        public static string ToTitles(string dataTypeName)
        {
            switch (dataTypeName.ToUpper())
            {
                case "VOL5":
                    return "+5V电压";

                case "VOL15":
                    return "+15V电压";

                case "VOLNEG15":
                    return "-15V电压";

                case "VOL28":
                    return "+28V电压";

                case "VOL45":
                    return "+45V电压";

                case "VOL510":
                    return "+510V电压";

                case "VOLFILAINVE":
                    return "灯丝逆变电压";

                case "VOLFILAMENT":
                    return "灯丝电压";

                case "VOLFIELD":
                    return "磁场电压";

                case "VOLTITPUMP":
                    return "钛泵电压";

                case "VOLELEBEAM":
                    return "电子注电压";

                case "VOLARTIFLINE":
                    return "人工线充电电压";

                case "CURCATHO":
                    return "阴极电流";

                case "CURREVERSEPEAK":
                    return "反峰电流";

                case "CURFILAMENT":
                    return "灯丝电流";

                case "CURFOCUSCOIL":
                    return "聚焦线圈电流";

                case "CURTITPUMP":
                    return "钛泵电流";

                case "CURLEVELING":
                    return "校平电流";

                case "CURARTIFLINE":
                    return "人工线充电电流";

                default:
                    return string.Empty;
            }
        }

        public static string ToProperties(string powerName)
        {
            switch (powerName.ToUpper())
            {
                case "+5V电压":
                    return "Vol5";

                case "+15V电压":
                    return "Vol15";

                case "-15V电压":
                    return "VolNeg15";

                case "+28V电压":
                    return "Vol28";

                case "+45V电压":
                    return "Vol45";

                case "+510V电压":
                    return "Vol510";

                case "灯丝逆变电压":
                    return "VolFilaInve";

                case "灯丝电压":
                    return "VolFilament";

                case "磁场电压":
                    return "VolField";

                case "钛泵电压":
                    return "VolTitPump";

                case "电子注电压":
                    return "VolEleBeam";

                case "人工线充电电压":
                    return "VolArtifLine";

                case "阴极电流":
                    return "CurCatho";

                case "反峰电流":
                    return "CurReversePeak";

                case "灯丝电流":
                    return "CurFilament";

                case "聚焦线圈电流":
                    return "CurFocusCoil";

                case "钛泵电流":
                    return "CurTitPump";

                case "校平电流":
                    return "CurLeveling";

                case "人工线充电电流":
                    return "CurArtifLine";

                default:
                    return string.Empty;
            }
        }
    }
}