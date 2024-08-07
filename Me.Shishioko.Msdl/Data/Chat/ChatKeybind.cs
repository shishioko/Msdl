﻿using Net.Myzuc.ShioLib;
using Newtonsoft.Json;
using System.IO;
using static System.Net.Mime.MediaTypeNames;
using System.Text;
using System.Web;
using System.Drawing;

namespace Me.Shishioko.Msdl.Data.Chat
{
    internal sealed class ChatKeybind : ChatComponent
    {
        public string Keybind;
        public ChatKeybind(string keybind)
        {
            Keybind = keybind;
        }
        internal override void TypeSerialize(Stream stream)
        {
            stream.WriteU8(8);
            stream.WriteString("type", SizePrefix.U16);
            stream.WriteString("keybind", SizePrefix.U16);
            stream.WriteU8(8);
            stream.WriteString("keybind", SizePrefix.U16);
            stream.WriteString(Keybind, SizePrefix.U16);
        }
        internal override void TypeTextSerialize(StringBuilder json)
        {
            json.Append("\"type\":\"keybind\",\"keybind\":\"");
            json.Append(HttpUtility.JavaScriptStringEncode(Keybind, false));
            json.Append("\",");
        }
        public override string ToString()
        {
            return $"[{Keybind}]" + base.ToString();
        }
        internal override void ToANSI(StringBuilder builder, bool bold, bool italic, bool underlined, bool strikethrough, bool obfuscated, Color color)
        {
            builder.Append("\u001b[0m");
            if (bold) builder.Append("\u001b[1m");
            if (italic) builder.Append("\u001b[3m");
            if (underlined) builder.Append("\u001b[4m");
            if (strikethrough) builder.Append("\u001b[9m");
            if (obfuscated) builder.Append("\u001b[5m");
            builder.Append("\u001b[7m");
            builder.Append($"\u001b[38;2;{color.R};{color.G};{color.B}m");
            builder.Append($"[{Keybind}]");
            base.ToANSI(builder, bold, italic, underlined, strikethrough, obfuscated, color);
        }
    }
}
