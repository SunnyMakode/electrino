﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;

namespace RenderAPI
{
    [AllowForWeb]
    public sealed class JSProcess
    {
        public string Platform
        {
            get
            {
                return "win32";
            }
        }

        private AppVersions _versions = new AppVersions();

        public AppVersions Versions
        {
            get
            {
                return _versions;
            }
        }

    }

    [AllowForWeb]
    public sealed class AppVersions
    {
        public string Electrino
        {
            get
            {
                return "0.1.0";
            }
        }
    }
}
