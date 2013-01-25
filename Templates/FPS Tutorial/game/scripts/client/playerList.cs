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
// Hook into the client update messages to maintain our player list and scores.
//
// The PlayerListGui handles both free-for-all and team based games. In
// free-for-all, all players are shown in a single list. In team games, each
// team has its own list of players and a summed team score.
//-----------------------------------------------------------------------------

addMessageCallback('MsgClientJoin', handleClientJoin);
addMessageCallback('MsgClientDrop', handleClientDrop);
addMessageCallback('MsgClientScoreChanged', handleClientScoreChanged);

function handleClientJoin(%msgType, %msgString, %clientName, %clientId, %guid,
      %team, %score, %kills, %deaths, %isAI, %isAdmin, %isSuperAdmin)
{
   PlayerListGui.update(%clientId, detag(%clientName), %isSuperAdmin, %isAdmin,
   %isAI, %team, %score, %kills, %deaths);
}

function handleClientDrop(%msgType, %msgString, %clientName, %clientId)
{
   PlayerListGui.remove(%clientId);
}

function handleClientScoreChanged(%msgType, %msgString, %score, %kills, %deaths, %clientId)
{
   PlayerListGui.updateScore(%clientId, %score, %kills, %deaths);
   echo("kills:"@%kills@" deaths:"@%deaths);
}

// ----------------------------------------------------------------------------
// GUI methods
// ----------------------------------------------------------------------------

function PlayerListGui::update(%this, %clientId, %name, %isSuperAdmin, %isAdmin, %isAI, %team, %score, %kills, %deaths)
{
   // Build the row to display.  The name can have ML control tags, including
   // color and font.  Since we're not using an ML control here, we need to
   // strip them off.
   %tag = %isSuperAdmin ? "[Super]" :
      (%isAdmin ? "[Admin]" :
      (%isAI ? "[Bot]" :
      ""));
   %text = StripMLControlChars(%name) SPC %tag TAB %deaths TAB %kills;

   scoreListCtrl.addRow(%clientId, %text);

   %this.updateScore(%clientId, %score, %kills, %deaths);
}

function PlayerListGui::updateScore(%this, %clientId, %score, %kills, %deaths)
{
   // Update this client's stats
   %text = scoreListCtrl.getRowTextById(%clientId);
   %text = setField(%text, 1, %deaths);
   %text = setField(%text, 2, %kills);
   
   scoreListCtrl.setRowById(%clientId, %text);

   scoreListCtrl.clearSelection();
}

function PlayerListGui::remove(%this, %clientId)
{
   // Remove this client from the team
   scoreListCtrl.removeRowById(%clientId);
}

function PlayerListGui::toggle(%this)
{
   if (%this.isAwake())
      Canvas.popDialog(%this);
   else
      Canvas.pushDialog(%this);
}

function PlayerListGui::displayAsDialog(%this, %visible)
{
   if (%visible)
   {
      %this-->DisconnectButton.setVisible(false);
      %this.noCursor = "1";
      Canvas.pushDialog( %this );
   }
   else
   {
      Canvas.popDialog( %this );
   }
}

function PlayerListGui::showFinalScores( %this )
{
   // Determine who won the game
   // Free-for-all: player with highest score wins
   %text = scoreListCtrl.getRowText(0); // sorted by score
   %winner = getField( %text, 0 );

   // Display the gui and indicate who won
   %this-->gameRules.setText(%winner SPC "wins the game!");
   
   %this-->timeRemainingPanel.setVisible(false);
   %this-->DisconnectButton.setVisible(true);
   %this.noCursor = "0";
   
   if ( !%this.isAwake() )
      Canvas.setContent( %this );
}

function PlayerListGui::clear(%this)
{
   scoreListCtrl.clear();
   PlayerListGuiTeams.updateLayout();
}

function PlayerListGui::zeroScores(%this)
{
   for (%j = 0; %j < scoreListCtrl.rowCount(); %j++)
   {
      %text = PlayerListGuiTeams-->teamList.getRowText(%j);
      %text = setField(%text, 1, "0");
      %text = setField(%text, 2, "0");
      %text = setField(%text, 3, "0");
      scoreListCtrl.setRowById(PlayerListGuiTeams-->teamList.getRowId(%j), %text);
   }
   scoreListCtrl.clearSelection();
}

function PlayerListGuiTeams::updateLayout( %this )
{
   %teamCount = PlayerListGuiTeams.getCount();
   if ( %teamCount <= 1 )
   {
      PlayerListGuiTeams.rows = "0";
      PlayerListGuiTeams.columns = "0";
      PlayerListGuiTeams.updateSizes();
   }
   else
   {
      // Make sure there are 2 columns if more than one team
      if ( %this.getColumnCount() < 2 )
         %this.addColumn();

      // Need a new row for every 2 teams
      while ((%teamCount / 2) < PlayerListGuiTeams.getRowCount())
         PlayerListGuiTeams.removeRow();
      while ((%teamCount / 2) > PlayerListGuiTeams.getRowCount())
         PlayerListGuiTeams.addRow();
   }
}
