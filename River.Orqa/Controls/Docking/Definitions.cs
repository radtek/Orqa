// *****************************************************************************
// 
//  (c) Crownwood Consulting Limited 2002 
//  All rights reserved. The software and associated documentation 
//  supplied hereunder are the proprietary information of Crownwood Consulting 
//	Limited, Haxey, North Lincolnshire, England and are supplied subject to 
//	licence terms.
// 
//  Magic Version 1.7 	www.dotnetmagic.com
// *****************************************************************************

using System;
using System.Drawing;
using River.Orqa.Controls.Common;
using River.Orqa.Controls.Collections;

namespace River.Orqa.Controls.Docking
{
    public enum State
    {
        Floating,
        DockTop,
        DockBottom,
        DockLeft,
        DockRight
    }

    public interface IHotZoneSource
    {
        void AddHotZones(Redocker redock, HotZoneCollection collection);
    }

    public interface IZoneMaximizeWindow
    {
        Direction Direction { get; }
        bool IsMaximizeAvailable();
        bool IsWindowMaximized(Window w);
        void MaximizeWindow(Window w);
        void RestoreWindow();
        event EventHandler RefreshMaximize;
    }

    // Delegate signatures
    public delegate void ContextHandler(Point screenPos);
}