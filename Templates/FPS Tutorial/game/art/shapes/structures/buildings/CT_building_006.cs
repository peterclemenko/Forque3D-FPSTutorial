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

singleton TSShapeConstructor(CT_building_006Dae)
{
   baseShape = "./CT_building_006.dae";
   loadLights = "0";
   unit = "0.1";
   upAxis = "DEFAULT";
   lodType = "TrailingNumber";
   matNamePrefix = "";
   ignoreNodeScale = "0";
   adjustCenter = "0";
   adjustFloor = "0";
   forceUpdateMaterials = "0";
};

function CT_building_006Dae::onLoad(%this)
{
   %this.renameSequence("ambient", "timeline");
   %this.setDetailLevelSize("800", "500");
   %this.setDetailLevelSize("400", "200");
   %this.setDetailLevelSize("100", "50");
}
