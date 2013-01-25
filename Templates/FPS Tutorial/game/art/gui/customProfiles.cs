//-----------------------------------------------------------------------------
// Copyright (c) 2012 GarageGames, LLC
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
//-----------------------------------------------------------------------------

//-----------------------------------------------------------------------------
// Game specific profiles are located here
//-----------------------------------------------------------------------------

singleton GuiControlProfile(ChinatownButton : GuiButtonProfile)
{
   category = "Chinatown";
};

singleton GuiControlProfile(OptionsTabBorder : GuiTabBorderProfile)
{
   bitmap = "art/gui/Options/VideoWindow";
   category = "Chinatown";
};

singleton GuiControlProfile(ChinatownSliderProfile : GuiSliderProfile)
{
   bitmap = "art/gui/Options/slider.png";
   category = "Chinatown";
};

singleton GuiControlProfile(ChinatownSliderProfile : GuiSliderProfile)
{
   bitmap = "art/gui/Options/slider.png";
};

singleton GuiControlProfile(ChinatownTextEditProfile : GuiTextEditProfile)
{
   profileForChildren = "";
   category = "Chinatown";
   fontColors[0] = "253 253 253 255";
   fontColor = "253 253 253 255";
   bitmap = "art/gui/textEditField.png";
   fontColors[1] = "1 1 1 255";
   fontColorHL = "1 1 1 255";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownHostTextProfile : GuiTextProfile)
{
   category = "Chinatown";
   fontColors[0] = "253 253 253 255";
   fontColor = "253 253 253 255";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownPopUpMenuProfile : GuiPopUpMenuProfile)
{
   bitmap = "art/gui/dropDown.png";
   fillColor = "1 1 1 255";
   fontColors[0] = "253 253 253 255";
   fontColor = "253 253 253 255";
   fillColorHL = "1 1 1 255";
   fillColorNA = "1 1 1 255";
   fontColors[1] = "253 253 253 255";
   fontColors[2] = "253 253 253 255";
   fontColorHL = "253 253 253 255";
   fontColorNA = "253 253 253 255";
   category = "Chinatown";
   cursorColor = "253 253 253 255";
   profileForChildren = "ChinatownPopUpMenuChildrenProfile";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownCheckboxProfile : GuiCheckBoxProfile)
{
   bitmap = "art/gui/checkbox.png";
   category = "Chinatown";
};

singleton GuiControlProfile(ChinatownTransparentScrollProfile : GuiTransparentScrollProfile)
{
   bitmap = "art/gui/scrollbar.png";
   category = "Chinatown";
   fillColor = "0 41 255 255";
   fillColorHL = "0 12 255 255";
   fillColorNA = "0 41 255 255";
   opaque = "0";
};

singleton GuiControlProfile(ChinatownTextArrayProfile : GuiTextArrayProfile)
{
   fillColor = "200 200 200 2";
   fillColorHL = "153 153 155 98";
   fontColors[0] = "87 200 86 255";
   fontColors[1] = "87 200 86 255";
   fontColors[3] = "87 200 86 255";
   fontColor = "87 200 86 255";
   fontColorHL = "87 200 86 255";
   fontColorSEL = "87 200 86 255";
   category = "Chinatown";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownPopUpMenuChildrenProfile : GuiPopUpMenuDefault)
{
   fillColor = "1 1 1 255";
   fillColorHL = "63 63 63 255";
   fillColorNA = "1 1 1 255";
   fontColors[0] = "253 253 253 255";
   fontColors[1] = "253 253 253 255";
   fontColors[2] = "253 253 253 255";
   fontColor = "253 253 253 255";
   fontColorHL = "253 253 253 255";
   fontColorNA = "253 253 253 255";
   bitmap = "art/gui/scrollbar.png";
   category = "Chinatown";
   fillColorSEL = "85 85 85 255";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownOptionsMenuLabelTextProfile : GuiTextProfile)
{
   category = "Chinatown";
   fontType = "vrinda";
   opaque = "0";
   modal = "0";
   fontSize = "30";
   fontColors[0] = "253 253 253 255";
   fontColor = "253 253 253 255";
   autoSizeWidth = "1";
   autoSizeHeight = "1";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownHUDTextProfile : GuiTextBoldCenterProfile)
{
   fontType = "vrinda bold";
   fontColors[0] = "32 223 252 255";
   fontColor = "32 223 252 255";
   fontSize = "60";
   category = "Chinatown";
};

singleton GuiControlProfile (ChatHudBorderProfile)
{
   bitmap = "core/art/gui/images/chatHudBorderArray";
   hasBitmapArray = true;
   opaque = false;
};

singleton GuiControlProfile(WeaponHUDNoBorderProfile : ChatHudBorderProfile)
{
   hasBitmapArray = "0";
};

singleton GuiControlProfile(ChinatownGuiProgressTextProfile : GuiProgressTextProfile)
{
   fontColors[0] = "253 253 253 255";
   fontColor = "253 253 253 255";
   category = "Chinatown";
   fontType = "Vrinda";
   fontSize = "18";
};

singleton GuiControlProfile(ChinatownAmmoAmountTextProfile : ChinatownHUDTextProfile)
{
   fontSize = "40";
};

singleton GuiControlProfile(ChatMessageTextListProfile : GuiTextListProfile)
{
   category = "Chinatown";
   fontType = "Vrinda";
   fontSize = "40";
   fontColors[0] = "253 253 253 255";
   fontColors[3] = "254 254 254 255";
   fontColor = "253 253 253 255";
   fontColorSEL = "254 254 254 255";
   justify = "Center";
};

singleton GuiControlProfile(JoinMessageTextListProfile : ChatMessageTextListProfile)
{
   fontSize = "30";
   fontColors[1] = "253 253 253 255";
   fontColors[2] = "253 253 253 255";
   fontColors[4] = "254 253 254 255";
   fontColors[5] = "254 253 254 255";
   fontColors[6] = "254 253 254 255";
   fontColors[7] = "254 253 254 255";
   fontColors[8] = "254 253 254 255";
   fontColors[9] = "254 253 254 255";
   fontColorHL = "253 253 253 255";
   fontColorNA = "253 253 253 255";
   fontColorLink = "254 253 254 255";
   fontColorLinkHL = "254 253 254 255";
   cursorColor = "253 253 253 255";
};

singleton GuiControlProfile(ChinatownEmptyAmmoAmountTextProfile : ChinatownAmmoAmountTextProfile)
{
   fontColors[0] = "254 2 9 255";
   fontColor = "254 2 9 255";
};

singleton GuiControlProfile(ChinatownRedHUDTextProfile : ChinatownHUDTextProfile)
{
   fontColors[0] = "254 2 9 255";
   fontColor = "254 2 9 255";
};
