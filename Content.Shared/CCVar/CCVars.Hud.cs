﻿using Robust.Shared.Configuration;

namespace Content.Shared.CCVar;

public sealed partial class CCVars
{
    public static readonly CVarDef<int> HudTheme =
        CVarDef.Create("hud.theme", 0, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<bool> HudHeldItemShow =
        CVarDef.Create("hud.held_item_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<bool> OfferModeIndicatorsPointShow =
        CVarDef.Create("hud.offer_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<bool> CombatModeIndicatorsPointShow =
        CVarDef.Create("hud.combat_mode_indicators_point_show", true, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<bool> LoocAboveHeadShow =
        CVarDef.Create("hud.show_looc_above_head", false, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<float> HudHeldItemOffset =
        CVarDef.Create("hud.held_item_offset", 28f, CVar.ARCHIVE | CVar.CLIENTONLY);

    public static readonly CVarDef<bool> HudFpsCounterVisible =
        CVarDef.Create("hud.fps_counter_visible", false, CVar.CLIENTONLY | CVar.ARCHIVE);

    public static readonly CVarDef<bool> ModernProgressBar =
        CVarDef.Create("hud.modern_progress_bar", true, CVar.CLIENTONLY | CVar.ARCHIVE);
}
