﻿//   SparkleShare, a collaboration and sharing tool.
//   Copyright (C) 2010  Hylke Bons <hi@planetpeanut.uk>
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU Lesser General Public License as 
//   published by the Free Software Foundation, either version 3 of the 
//   License, or (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program. If not, see <http://www.gnu.org/licenses/>.


using System.IO;

namespace Sparkles {

    public class SSHCommand : Command
    {
        public static string SSHPath = "";

        public static string SSHCommandPath {
            get {
                return Path.Combine (SSHPath, "ssh").Replace ("\\", "/");
            }
        }


        public SSHCommand (string command, string args) : this (command, args, null)
        {
        }


        public SSHCommand (string command, string args, SSHAuthenticationInfo auth_info) :
            base (Path.Combine (SSHPath, command), args)
        {
        }
    }
}
