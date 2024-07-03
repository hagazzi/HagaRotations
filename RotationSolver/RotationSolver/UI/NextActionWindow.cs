﻿using Dalamud.Interface.Colors;
using Dalamud.Interface.Windowing;
using ECommons.GameHelpers;
using FFXIVClientStructs.FFXIV.Client.Game;
using RotationSolver.Basic.Configuration;
using RotationSolver.Updaters;

namespace RotationSolver.UI;

internal class NextActionWindow : Window
{
    const ImGuiWindowFlags BaseFlags = ControlWindow.BaseFlags
    | ImGuiWindowFlags.AlwaysAutoResize
    | ImGuiWindowFlags.NoResize;

    public NextActionWindow()
        : base(nameof(NextActionWindow), BaseFlags)
    {
    }

    public override void PreDraw()
    {
        ImGui.PushStyleColor(ImGuiCol.WindowBg, Service.Config.InfoWindowBg);

        Flags = BaseFlags;
        if (Service.Config.IsInfoWindowNoInputs)
        {
            Flags |= ImGuiWindowFlags.NoInputs;
        }
        if (Service.Config.IsInfoWindowNoMove)
        {
            Flags |= ImGuiWindowFlags.NoMove;
        }
        ImGui.PushStyleVar(ImGuiStyleVar.WindowBorderSize, 0);
        base.PreDraw();
    }

    public override void PostDraw()
    {
        ImGui.PopStyleColor();
        ImGui.PopStyleVar();
        base.PostDraw();
    }

    public override unsafe void Draw()
    {
        var width = Service.Config.ControlWindowGCDSize
            * Service.Config.ControlWindowNextSizeRatio;
        DrawGcdCooldown(width, false);

        var precent = 0f;

        var group = ActionManager.Instance()->GetRecastGroupDetail(ActionHelper.GCDCooldownGroup - 1);
        if (group ->Elapsed == group->Total || group->Total == 0)
        {
            precent = 1;
        }
        else
        {
            precent = group->Elapsed / group->Total;
            if(ActionUpdater.NextAction != ActionUpdater.NextGCDAction)
            {
                precent++;
            }
        }

        ControlWindow.DrawIAction(ActionUpdater.NextAction, width, precent);
    }

    public static unsafe void DrawGcdCooldown(float width, bool drawTittle)
    {
        var remain = DataCenter.DefaultGCDRemain;
        var total = DataCenter.DefaultGCDTotal;
        var elapsed = DataCenter.DefaultGCDElapsed;

        if (drawTittle)
        {
            var str = $"{remain:F2}s / {total:F2}s";
            ImGui.SetCursorPosX(ImGui.GetCursorPosX() + width / 2 - ImGui.CalcTextSize(str).X / 2);
            ImGui.Text(str);
        }

        var cursor = ImGui.GetCursorPos() + ImGui.GetWindowPos();
        var height = Service.Config.ControlProgressHeight   ;

        ImGui.ProgressBar(elapsed / total, new Vector2(width, height), string.Empty);

        var actionRemain = DataCenter.DefaultGCDRemain;
        if (actionRemain > 0)
        {
            var value = total - DataCenter.ActionAhead;

            if (value > Player.Object.TotalCastTime)
            {
                var pt = cursor + new Vector2(width, 0) * value / total;

                ImGui.GetWindowDrawList().AddLine(pt, pt + new Vector2(0, height),
                    ImGui.ColorConvertFloat4ToU32(ImGuiColors.DalamudRed), 2);
            }
        }
    }
}
