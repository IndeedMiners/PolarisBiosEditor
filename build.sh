#!/bin/bash
mcs -unsafe -lib:/usr/lib/mono/4.0 -r:System.Drawing.dll -r:System.Windows.Forms.dll PolarisBiosEditor.cs PolarisBiosEditor.Designer.cs
