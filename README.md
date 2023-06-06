<div dir='rtl' lang='he'>

# Multiplayer games using Photon Fusion

I chose the option of adding points to the players. notice I fixed the game that you can only hit others, and not yourself.

## How?
1. Added canvas and a text inside in the top left corner.
2. Added an object named GameManager that responsible to it, it has a script inside named score that updates the score to the current one.
3. Added inside RayCastAttack script a call to the function inside the score script, and by that the score is updated.

</div>