# Template kod för spelprojekt

För att bygga en grundläggande prototyp av ett sidescroller-spel får ni följande C#-skript. Här är en förklaring av varje skript


### `PlayerMovement`
*Kräver en Rigidbody2D på samma objekt*

Scriptet gör att objektet rör sig höger/vänster och upp/ner inom kamerans vy efter tangenterna WASD och piltangenterna.

Redigera if-satserna i koden för att ändra vilka tangenter som styr spelaren.

* `Movement Speed` styr hur snabbt spelaren rör sig.

### `Enemy`
*Kräver en Rigidbody2D på samma objekt*
Scriptet gör att objektet rör sig enligt ett zick-zack mönster.

* `Velocity` Vector2 som styr hastighet och riktning
* `Zig Zag Time` tid som styr hur ofta objektet byter riktning
* `Zig Zag Direction` avgör om fienden rör sig horisontellt eller vertikalt

### `Spawner`
Scriptet gör att det spawnas objekt vid en angiven knapptryckning och efter en angiven cooldown-tid. Anges ingen knapptryckning skapas det objekt automatiskt.

* `Fire Button` vid vilken knapp ska objekt skapas.
* `Fire Direction` åt vilket håll ska objektet åka.
* `Cool Down` hur lång tid mellan att objekten skapas
* `Prefab` vilket objekt som spawnas. Kan till exempel vara ett skott eller en fiende.
* `Spawn Location` vid vilken plats ska objekten skapas (kan lämnas tom)

### `EnemyHealth`

Scriptet håller koll på antal liv objektet har kvar. Liven minskas när objektet kolliderar med ett objekt som har `HurtEnemy`-komponenten. När liven är slut anropas tas objektet bort från spelet.

* `Max Health` hur många liv objektet har från början.
* `Hurt Sound` det ljud som ska spelas när objektet blir träffat
* `Death Object` det objekt som ska spawnas när fienden dör.

### `HurtEnemy`

Scriptet gör att liven minskar hos en `EnemyHealth` komponenent när objekten kolliderar. Objektet tas också bort vid en kollision.

* `Hurt Amount` hur många liv som tas bort vid kollision.

### `PlayerHealth`
Scriptet håller koll på antal liv spelaren har kvar. Liven minskas när objektet kolliderar med ett objekt som har `HurtPlayer`-komponenten. När liven är slut anropas metoden `GameOver`

* `Max Health` hur många liv spelaren har från början.
* `Hurt Sound` det ljud som ska spelas när objektet blir träffat
* `Game Over Scene Name` namnet på den scen spelet ska byta till när spelaren har slut på liv.


### `HurtPlayer`

Scriptet gör att liven minskar hos en `PlayerHealth` komponenent när objekten kolliderar. Objektet tas också bort vid en kollision.

* `Hurt Amount` hur många liv som tas bort vid kollision.

### `SceneChanger`

Scriptet kan du använda på två sätt:
* lägg skriptet på ett objekt med en trigger. Om något åker in i triggern byter spelet scen till den som är angiven i `New Scene Name`.
* lägg skriptet på en knapp. Om man trycker på knappen byter spelet scen till den som är angiven i `New Scene Name`.




