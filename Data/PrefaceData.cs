using System.Collections.Generic;
using System.Linq;
using YorubaCatholicHymn.Models;

namespace YorubaCatholicHymn.Data
{
    public static class PrefaceData
    {
        public static List<Preface> GetPrefaces()
        {
            return new List<Preface>
            {
                // Prayer-specific prefaces (II, V, VI) - appear first when their prayer is selected
                new Preface
                {
                    PrayerNumber = "II",
                    Season = "Preface for Eucharistic Prayer II",
                    Title = "Àdúrà Yukaristí Kejì - Preface",
                    Comment = "Own preface for Eucharistic Prayer II. This appears first when II is selected.",
                    Text = @"Nítòótó ó ye, ó sì tó,
ojús e wa àti orísun ìgbàla wa ni,
ká máa dúpé ló wó ò Re, Baba Mímó jùlo,
nígbà gbogbo àti níbi gbogbo,
nípasè Jésù Krístì O mo ò Re àyànfé 
E ni tí Í s e Ò rò Re, nípasè E ni tí O dá ohun gbogbo,
E ni tí O rán gé gé bí Olùgbàlà àti Olùràpadà wa,
tí Ó gba ara ènìyàn nípasè È mí Mímó,
tí a sì bí I láti inú Wúndíá.

Ó mú ìfé Re s e
Ó jèrè ìjo ènìyàn mímó kan fún O,
Ó na o wó Rè bí Ó ti ín farada Ìjìyà Rè
Kí Ó ba lè já ìdè ikú
Kí Ó sì s e ìfihàn ti àjíde.

Nítorí náà, pè láti àwo ángé lì àti gbogbo àwo ènìyàn mímó
ni àwa kéde ògo Re,
tí a sì  wí pè láti ohun kan pé:
"
                },
                new Preface
                {
                    PrayerNumber = "V",
                    Season = "ORIN-ÌYÌN FÚN MÍSÀ ÌLÀJÀ kìnní",
                    Title = "ORIN-ÌYÌN FÚN MÍSÀ ÌLÀJÀ kìnní",
                    Comment = "A lè lo àwo Orin-Ìyìn míràn tó je mó ti Ìdáríjì-è è àti Ìrònúpìwàdà, fún àpe e re, Orin-Ìyìn Ìgbà Ààwè.",
                    Text = @"Nítòótó, ó ye, ó sì tó,
ojús e wa ni láti máa dúpé nígbà gbogbo,
Olúwa, Baba Mímó, O lórun Olódùmarè àti ayérayé.

Ìwo kò dé kun láti máa fún wa ní ìsírí
láti lè jogún è kúnré ré ìyè,
bí O sì ti kún fún àànú,
Ìwo ko dé kun láti máa fún un ní ìdáríjì
O sì  pe àwo e lé sè
láti ní ìgbé kèlé nínú ìdáríjì Re nìkan s soso.

Bí ó tilè jé pé ní òpòlo pò ìgbà ni a  lòdì sí májè mú Re
Ìwo kò fi ìgbà kankan kò wá sílè;
nípasè Jésù O mo Re, Olùràpadà wa,
Ìwo ti so ìdílé o mo ènìyàn pò mó ara Re
pè láti èdìdì ìfé tuntun tó lágbára tó béè gé gé
tí ohun kóhun kò lè pa á run.

Bákan náà nísinsìnyí,
Ìwo fi àkókò oore-òfé àti ìlàjà fún àwo ènìyàn Re;
bí o kàn wo n sì  n fà sí O,
Ìwo  n fún wo n ní ìrètí nínú Krístì Jésù,
O sì  n fún wo n ní ànfàní láti jé olùrànló wó fún gbogbo èdá
bí wo n sì  n jò wó ara wo n ní è kúnré ré fún agbára È mí Mímó.

Nítorí náà,
nínú ayò àgbàyanu yìí
àwa  pòkìkí agbára ìfé Re
a sì kéde ìgbàlà wa pè láti ayò,
a  n darapò mó ogúnló gò àwo e gbé ogun ò n
nínú orin wo n bí a ti  wí láìsinmi pé:
"
                },
                new Preface
                {
                    PrayerNumber = "VI",
                    Season = "ORIN-ÌYÌN FÚN MÍSÀ ÌLÀJÀ kejì",
                    Title = "ORIN-ÌYÌN FÚN MÍSÀ ÌLÀJÀ kejì",
                    Comment = "A lè lo àwo Orin-Ìyìn míràn tó je mó ti Ìdáríjì-è è àti Ìrònúpìwàdà, fún àpe e re, Orin-Ìyìn Ìgbà Ààwè.",
                    Text = @"Nítòótó, ó ye, ó sì tó,
ojúse wa ni láti máa dúpé, ká sì máa fi ìyìn fún O,
Olórun Baba Olódùmarè
fún gbogbo ohun tí Ìwo  n s e ní ayé yìí
nípasè Olúwa wa Jésù Kristì.

Bí ó tilè jé pé ìran èdá wà ní ipò ìyapa,
tí wo n sì pin yé lé-yé lé nípa àìgbó ra-e ní yé,
síbè síbè, nínú àwo ìrírí yìí,
a  rí o wó ò Re,
o kàn wa  n fà sí O,
O sì  n mú wa gbáradì fún ètò ìlàjà tí Ìwo  n fé.

Ju béè lo pàápàá, nípa agbára È míì Re,
Ìwo  n fi o wó tó o kàn ènìyàn
tí ó fi jé pé
Ìré pò  n padà sí àárín àwo tó rí ara wo n bíi ò tá,
àwo alátakò  na o wó ìfé sí ara wo n,
gbogbo ènìyàn sì  n wá ò nà láti máa wà ní ìré pò.

Olúwa, pè láti agbára is é è Re,
ìfé ti gbé ìkórìíra mì,
ìgbè san ti pòórá níwájú ìdáríjì,
àìgbó ra-e ní yé sì ti ye ra fún ìfé tòótó.

Nítorí náà,
pè láti ogúnló gò àwo ángé lì ní àgbàlá ò n
ni àwa  n dúpé ló wó ò Re
tí a sì  kéde o lánlá à Re ní ayé láìsinmi pé:
"
                },

                // Fixed own-preface prayers (IV, VII, VIII, IX, X) - no picker, only these show
                new Preface
                {
                    PrayerNumber = "IV",
                    Season = null,
                    Title = null,
                    Comment = null,
                    Text = @"Nítòótó ló tó ká máa fi o pé fún O,
nítòótó ló ye ká máa yìn Ó lógo, Baba mímó,
nítorí Ìwo nìkan ni O lórun alààyè àti òtító,
Ìwo tí Ó wà kí ìgbà tó wà,
tí O sì  bé títí ayérayé,
tí O  bé nínú ìmó lé tí a kò lè súnmó;
síbè tó jé pé Ìwo nìkan ni Ó jé rere àti orísun ìyè,
tí O sì dá ohun gbogbo,
kí O baà lè kún àwo èdá à Re pè láti ìbùkún,
kí O sì fi ayò fún wo n nípa ògo ìmó lé Re.

Ní iwájú ù Re ni ogúnló gò e gbé-ogun àwo ángé lì wà
tí wo n  sìn Ó tòsán-tòru
tí wo n  wo ògo ojúù Re,
tí wo n sì  yìn Ó lògo láìdánudúró.

Pè láti wo n, àwa náà  n fi tayò tayò jéwó orúko ò Re,
a sì  n gba ò rò so fún gbogbo àwò n èdá tí  bé lábé ò n
bí a ti  n ko rin pé:
"
                },
                new Preface
                {
                    PrayerNumber = "VII",
                    Season = null,
                    Title = "Orin-Ìyìn Mísà fún  orís irísi èrògbà èkínní:",
                    Comment = null,
                    Text = @"Fún Ìjo nínú ìrìnàjò Ìré pò

Nítòótó, ó ye, ó sì tó,
ká máa dúpé fún O, ká sì máa ko rin ògo àti iyin sí O,
Olúwa, Baba onínú rere tí kò ní àkàwé.

Nítorí nípa Ìyìnrere O mo ò Re
láti inú gbogbo ènìyàn, gbogbo èdè, àti àwo orílè-èdè
Ìwo ti kó àwo ènìyàn Re jo gé gé bí ìjo kan,
Ìwo  n fún un ni iyè pè láti agbára È mí Mímó Re
Ìwo kò dé kun láti máa kó gbogbo ènìyàn jo nínu agbo kan náà.

Agbo yìí  n fi májè mú ìfé Re hàn,
Ó  n pín ìrètí ìbùkún Ìjo ba Re láìsinmi
Ó sì  n s e àfihàn ìsòdodo Re gé gé bíi àmì
eyí tí O ti s e ìlérí rè láti ayérayé
nínú Jésù Krístì Olúwa wa.

Nítorí náà, pè láti gbogbo agbára ò n
àwa  n yìn Ó láìdé kun ní ayé
àwa sì  n wí ní ohun kan pè láti gbogbo Ìjo pé:
"
                },
                new Preface
                {
                    PrayerNumber = "VIII",
                    Season = null,
                    Title = "Orin-Ìyìn Mísà fún  orís irísi èrògbà ìkejì:",
                    Comment = null,
                    Text = @"O lórun tí Ó  darí Ìjo Rè ní ò nà ìgbàlà

Nítòótó, ó ye, ó sì tó,
ojús e wa àti ìgbàlà wa ni láti máa dúpé fún O
nígbà gbogbo, àti níbi gbogbo
Olúwa, Baba Mímó, E lé dáá ayé àti orisun gbogbo ìyè.

Nítorí Ìwo kò fi ìgbà kankan ko àwo is é o gbó n Re sílè
sùgbó n O  tè síwájú
láti máa fi oore-òfé Re s is é ní àárín wa.
Pè láti agbára o wó  n lá Re,
Ìwo darí àwo ènìyàn Re, Ísráé lì,
nínú ahoro asálè;
sùgbó n nísinsìnyí  Ìwo  n fi agbára È mí Mímó Re
bá Ìjo Re rìn nínú ìrìnàjo rè ní ayé yìí,
Ò  n dari rè lé nu ìrìnàjò Ìréko já yìí
lo sínú ayò àìnípè kun ti Ìjo ba Re
nípasè Krístì Olúwa wa.

Nítorí náà, pè láti àwo ángé lì àti àwo ènìyàn mímó
àwa  n ko rin ògo Re
a sì  n wí láìsinmi pé:
"
                },
                new Preface
                {
                    PrayerNumber = "IX",
                    Season = null,
                    Title = "Orin-Ìyìn Mísà fún  orís irísi èrògbà ìke ta:",
                    Comment = null,
                    Text = @"Jésù, ò nà tó lo só dò Baba

Nítòótó, ó ye, ó sì tó,
ojús e wa àti ìgbàlà wa ni láti máa dúpé fún O
nígbà gbogbo, àti níbi gbogbo
Olúwa, Baba Mímó, E lé dáá ò n oun ayé,
nípasè Krístì Olúwa wa.

Nítorí nípa Ò rò Re ni Ìwo dá ayé,
tí O sì  n s e àkóso ohun gbogbo pè láti ètò,
O fún wa ní Krístì,
Ò rò tí a so di Ara, gé gé bí onílàjà,
E ni tí Ó so ò rò Re fún wa,
Òun ni ò nà tí a  gbà dé ò dò Re,
Òun ni Òtító, èyí tó so wá di òmìnira,
Òun náà sì ni Ìyè, èyí tó kún wa fún ayò.

Nípasè O mo ò Re,
Ìwo kó àwo ènìyàn jo,
ló kùnrin lóbìnrin,
sínú ìdílé kan,
O dá wo n fún ògo orúko ò Re
O rà wo n padà nínú È je Krístì lórí àgbélébùú
O sì ti fi È mí Mímó Re s e àmì sí wo n lára.

Nítorí náà, nísinsìnyí àti títí ayérayé
àwa  kéde ògo Re pè láti àwo ángé lì
a sì  n fi tayò tayò s e àjo yò
bí a ti  n wípé:
"
                },
                new Preface
                {
                    PrayerNumber = "X",
                    Season = null,
                    Title = "Orin-Ìyìn Mísà fún  orís irísi èrògbà ìke rin:",
                    Comment = null,
                    Text = @"Jésù, akiri-s oore

Nítòótó, ó ye, ó sì tó,
ojús e wa àti ìgbàlà wa ni láti máa dúpé fún O
nígbà gbogbo, àti níbi gbogbo
Baba aláàánú àti O lórun olódodo:

Nítorí Ìwo ti fún wa ní Jésù Krístì, O mo ò Re,
gé gé bí Olúwa àti Olùgbàlà wa.

O mo ò Re tó fi ara Rè hàn nígbà gbogbo
gé gé bí orísun àànú fún àwo o mo dé àti àwo òtòsì,
fún àwo aláìlera àti àwo e lé sè,
O dúró ti àwo ti a  nilára àti tí a  n je níyà.

Nípa ò rò àti is é e Rè,
Ó kéde fún gbogbo àgbáyé pé
Ìwo ni O lórun Baba wa
àti pé Ìwo  n bójútó gbogbo àwo o mo ò Re.

Nítorí náà, pè láti gbogbo àwo ángé lì àti àwo ènìyàn mímó
ni àwa  n yìn Ó, tí a  n fi ìbùkún fún O
a sì  n ko rin ògo Re bí a ti  n wi láìsinmi pé.
"
                },

                // General prefaces (PrayerNumber = null) - for prayers I, III, and as options for II, V, VI

                new Preface
                {
                    Season = "ÌGBÀ ÌRETÍ WÍWÁ OLÚWA (I)",
                    Title = "Wíwá a Jésù lé̩è̩mejèèjì",
                    Comment = "A ń lo Orin-Ìyìn yìí láti o̩jó̩-ò̩sè̩ kìnní ìgba Ríretí títí di 16 Dìsé̩mbà",
                    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Kristi Olúwa wa.

Nígbà tí Ó kó̩ wá, 
tí Ó sì fi ìrè̩lè̩ gba e̩ran ara wa
Ó mú ìlérí ìgbàanì s̩e̩
Ó sì s̩í ò̩nà ìyè àìnípè̩kun fún wa,
pé nígbà tí Ó bá padà wá nínú ògo o̩láńlá a Rè̩
ká lè rí ìdánilójú ìyè àìnípè̩kun gbà,
ìlérí èyí tí a ń fi ìgbaradì dúró de wíwá a rè̩.

Nítorí náà, pè̩lú àwo̩n ángé̩lì àti àwo̩n olórí i ángé̩lì
pè̩lú àwo̩n ìté̩ àti agbára
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:
"
                },

                new Preface
                {
                    Season = "ÌGBÀ ÌRETÍ WÍWÁ OLÚWA (II) ",
                    Title = "Ìfojúsó̩nà de wíwá a Jésù lé̩è̩mejèèjì",
                    Comment = "A ń lo Orin-Ìyìn yìí láti 17 títí di 24 Disé̩mbà nígbà Ríretí",
                    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Kristi Olúwa wa.

E̩ni tí gbogbo àwo̩n wòlíì so̩ àso̩té̩lè̩ e̩ Rè̩
tí ìyá a Rè̩ tó jé̩ Wúndíá lóyún un Rè̩ pè̩lú ìfé̩ tí a kò lè fe̩nu so̩
Jòhánù oníbatisí kéde wíwá a Rè̩
Ó sì fí Í hàn nígbà tí Ó dé

E̩ni tí Ó pè wá láti fi ayò̩ dúró de ohun-ìjìnlè̩ ìbí i Rè̩
kí Ó lè bá wa pè̩lú ìdúrós̩ins̩in nínú àdúrà àti ohùn ìyìn ògo Rè̩
nígbà tí Ó bá padà wá.

Nítorí náà, pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì
pè̩lú àwo̩n ìté̩ àti agbára
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩,
tí a sì ń wí láìsinmi pé:"
                },

                new Preface
                {
                    Season = "ÌGBÀ KÉRÉSÌMESI/IBÍ OLÚWA (I)",
                    Title = "Krístì ìmó̩lè̩ ayé",
                    Comment = null, // no comment for this one
                    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nípa ohun-ìjìnlè̩ Ò̩rò̩ tí a so̩ di ara,
iná ìmó̩lè̩ àgbàyanu ùn Re̩ tuntun ti tàn sí òye o̩kàn an wa:
pé, gé̩gé̩ bí a ti mo̩ O̩ló̩run lójúkoojú
ká lè fà wá sínú ìfé̩ O̩ló̩run tí a kò lè fi ojú rí.

Nítorí náà, pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì
pè̩lú àwo̩n ìté̩ àti agbára
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩,
tí a sì ń wí láìsinmi pé:
"
                },
                  new Preface
                {
                    Season = "ÌGBÀ KÉRÉSÌMESI/IBÍ OLÚWA (II)",
                    Title = "Ìso̩ ohun gbogbo dò̩tun nípa Ìsò̩rò̩-di-ara",
                    Comment = null,
                    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Kristi Olúwa wa.

Ní àkókò aye̩ye̩ ohun-ìjìnlè̩ ìbo̩lá-fún yìí,
Ò̩rò̩ Re̩, E̩ni tí a kò rí ní ojúkoojú
s̩ùgbó̩n tí Ó fi ara hàn nínú e̩ran-ara bíi tiwa;
a bíi s̩íwájú ìbè̩rè̩ ayé gbogbo
Ó sì bè̩rè̩ sí ní wà nínú ìgbà;

Pé bí Ó s̩e ń gbé gbogbo ohun tó ti s̩ubú dìde nínú un Rè̩, 
kí Ó lè dá ògo padà fún gbogbo è̩dá
kí Ó sì pe gbogbo àwo̩n tó ti s̩áko lo̩
padà sínú ayò̩ ìjo̩ba ò̩run

Nítorí náà, pè̩lú gbogbo àwo̩n ángé̩lì,
àwa ń yin Ó̩,
a si ń fi ayò̩ kéde ògo ò Re̩ pé:

"
                },

                new Preface
                {
                    Season = "ÌGBÀ KÉRÉSÌMESI/IBÍ OLÚWA (III) ",
                    Title = "Èrè e síso̩ Ò̩rò̩ di ara",
                    Comment = null,
                    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Kristi Olúwa wa.
\n\n
Nípasè̩ e̩ Rè̩ ni pàs̩ípààrò̩ mímó̩ o̩ ti ìràpada wa fi ara hàn
nínú e̩wà ògo lónìí:
nítorí ní ìgbà tí Ò̩rò̩ Re̩ gbé àìlera wa wò̩
kìí s̩e pé ara ìdíbàje̩ wa gba ògo àìdíbàjé̩ nìkan
s̩ùgbó̩n nípasè̩ ìs̩o̩kan àgbàyanu yìí
Ó so̩ àwa náà di e̩ni àìkú.\n\n

Nítorí náà, pè̩lúu e̩gbé̩ ako̩rin àwo̩n ángé̩lì
àwa ń yin Ó̩,
a sì ń wí pè̩lu ayò̩ pé:"
                },
        new Preface
{
    Season = "ÌFIHÀN OLÚWA / EPIFANI",
    Title = "Krístì ni Ìmó̩lè̩ àwo̩n orílè̩-èdè",
    Comment = "A ń lo Orin-Ìyìn yìí nígbà o̩dún Ìfarahàn Olúwa. A sì lè lòó tàbí ò̩kàn nínú àwo̩n orin Ìyìn Kérésìmesi lé̩yìn o̩dún Ìfarahàn títí di Sátidé tó kángun sí o̩dún Ìbatisí Olúwa.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

(Lónìí,) Ìwo̩ ti fi ohun-ìjìnlè̩ ìgbàla wa hàn nínú un Krístì,
gé̩gé̩ bí ìmó̩lè̩ fún gbogbo orílè̩-èdè
nígbà tí Ó sì fi ara hàn nínú ara ìdíbàjé̩ wa
Ó so̩ wá dò̩tun nípa ògo àìdíbàjé̩ e̩ tirè̩.

Nítorí náà, pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì
pè̩lú àwo̩n ìté̩ àti agbára
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÀKÓKÒ ÀÀWÈ̩ (I)",
    Title = "Ìtumò̩ àti àǹfàní àkókò ìséra-e̩ni",
    Comment = "A ń lo Orin-Ìyìn yìí ní àkókò Ààwè̩ ati ní O̩jó̩ Ò̩sè̩ nígbà Ààwé̩ tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé,
nípasè̩ Krístì Olúwa wa.

Ní o̩do̩o̩dún, Ìwo̩ ń fún àwo̩n onígbàgbó̩ ò̩ Re̩ ní oore-ò̩fé̩,
pè̩lú ìwè̩nùmó̩ o̩kàn an wo̩n,
láti máa fi tayò̩tayò̩ gbaradì fún àwo̩n ohun-ìjìnle̩ ti àjíǹde.
pé, nípa is̩é̩ àánú àti àdúrà,
pè̩lú ìbápín nínú àwo̩n ohun-ìjìnlè̩ yìí, nínú èyí tí wó̩n ti di àtúnbí,
kí wó̩n lè dé ibi è̩kúnré̩ré̩ ògo ti àwo̩n o̩mo̩ ò̩ Re̩.

Nítorí náà, pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì
pè̩lú àwo̩n ìté̩ àti agbára
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩,
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÀKÓKÒ ÀÀWÈ̩ (II)",
    Title = "È̩mí Ìrònúpìwàdà",
    Comment = "A ń lo Orin-Ìyìn yìí ní àkókò Ààwè̩ ati ní O̩jó̩ Ò̩sè̩ nígbà Ààwé̩ tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:

Ìwo̩ ti s̩e ètò àkókò pàtàkì yìí
fún àwo̩n o̩mo̩ ò̩ Re̩ láti we̩ o̩kàn an wo̩n mó̩,
pé, pè̩lú o̩kàn tí a ti gbà là kúrò nínú ìfé̩kúfè̩é̩ ara
kí wó̩n lè máa lo àwo̩n ohun ti ayé yìí tí ń réko̩já-lo̩ bí ó ti tó̩
kí wó̩n sì lè di àwo̩n ohun ayérayé mú gírígírí.

Nítorí náà, pè̩lú àwo̩n ángé̩lì àti àwo̩n ènìyàn mímó̩
àwa ń yìn Ó̩ a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÀKÓKÒ ÀÀWÈ̩ (III)",
    Title = "Àwo̩n èso ìséra-e̩ni",
    Comment = "A ń lo Orin-Ìyìn yìí ní àkókò Ààwè̩ ati ní àwo̩n o̩jó̩ tí a gbó̩dò̩ gbààwè̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Ìwo̩ ń fé̩ ká máa fi ògo fún O̩ nípa ìséra-e̩ni
pé kí àwo̩n ìséra-e̩ni yìí yo̩ àwa e̩lé̩s̩è̩ kúrò nínú ifé̩kúfè̩é̩ ara
kí ó di orísun ìpèsè fún àwo̩n tí ebi ń pa
kí ó sì mú wa jé̩ aláwòkó̩s̩e àánú ùn Re̩.

Nítorí náà, pè̩lú ogúnló̩gò̩ àwo̩n ángé̩lì
ni àwa ń fi ohùn kan gbé O̩ ga pè̩lú orin ìyìn,
tí a sì ń wípé:"
},
new Preface
{
    Season = "ÀKÓKÒ ÀÀWÈ̩ (IV)",
    Title = "Àwo̩n èso ààwè̩",
    Comment = "A ń lo Orin-Ìyìn yìí ní àkókò Ààwè̩ ati ní àwo̩n o̩jó̩ tí a gbó̩dò̩ gbààwè̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé

Nígbà tí a bá ń gba ààwè̩, 
Ìwo̩ ń bá wa te̩ ìfé̩kúfè̩é̩ ara wa mó̩lè̩
O ń gbé o̩kan wa ga sókè,
O sì ń fún wa ní ìwà rere àti àwo̩n è̩bùn un wo̩n
nípasè̩ Krístì Olúwa wa,

Nínú E̩ni tí àwo̩n ángé̩lì ń yin o̩láńlá à Re̩,
tí àwo̩n ogun ò̩run ń te̩ríba,
tí àwo̩n agbára náà sì ń wárìrì níwájú ù Re̩.
Ò̩run àti àwo̩n agbára ò̩run
pè̩lú àwo̩n Séráfù mímó̩ ń fi ayò̩ yìn Ó̩.

Àwa n bè̩ Ó̩, jé̩ ká lè da ohùn wa pò̩ s̩ò̩kan pè̩lúu wo̩n
nínú orin ìrè̩lè̩
bí a ti ń wípé:"
},
new Preface
{
    Season = "ÌJÌYÀ OLÚWA (I)",
    Title = "Agbára Àgbélébùú",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Ò̩sè̩ karùn ún ti Ìgbà Ààwè̩ àti ní gbogbo Mísa ò̩rò̩ ìjìnlè̩ ti Àgbélebùú àtí nínú Ò̩sè̩ Ìjìyà Olúwa.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé

Ìjìyà àti ikú O̩mo̩ ò̩ Re̩ tí mú ìyè padà wá fún gbogbo àgbáyé, 
ó sì s̩e bé̩è̩ fà wá ló̩kàn láti máa yìn Ó̩ lógo. 
Agbára àgbélébu fi ìdájó̩ ò̩ Re̩ hàn 
lórí ayé pè̩lú ijo̩ba Krístì, 
E̩ni tí a kàn mó̩ àgbélébùú.

Àwa ń yìn Ó̩, Olúwa, 
pè̩lú gbogbo àwo̩n ángé̩lì àti àwo̩n ènìyàn mímó̩ 
nínú orin ayò̩ wo̩n tí wó̩n fi ń yìn Ó̩ lógo wípé:"
},

new Preface
{
    Season = "ÌJÌYÀ OLÚWA (II)",
    Title = "Àjàs̩é̩gun ìjìyà",
    Comment = "A ń lo Orin-Ìyìn yìí ní o̩jó̩ Monday, Tuesday àti Wednesday nínú Ò̩sè̩ Mímó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Kristi Olúwa wa.

Àwo̩n o̩jó̩ tí Ó jìyà ikú tí ń fún-ni ní ìyè 
àti Àjíǹde Rè̩ ológo ti ń súnmó̩ ìtòsí. 
Èyí ni àkókò náà tí Ó s̩é̩gun ìgbéraga ès̩ù, 
àkókò tí a ń s̩e àjò̩dún ìs̩è̩lè̩ ńlá a ti ìràpada wa.

Nípasè̩ Kristi ni àwo̩n ángé̩lì ń fi àdúrà bo̩lá fún O̩ 
pè̩lú ayò̩ níwájú ù Re̩ títí láé. 
E̩ jé̩ ká da ohùn wa pò̩ s̩ò̩kan pè̩lúu tiwo̩n 
bí wó̩n ti ń fi orin ayò̩ yìn Ó̩ lógo wípé:"
},
new Preface
{
    Season = "AJINDE (I)",
    Title = "Ohun-ìjìnlè̩ Àjíǹde",
    Comment = "",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa kéde ògo ò Re̩, Olúwa, nígbà gbogbo
àti nípàtàkì ká máa yìn Ó̩ lógo ní o̩jó̩ yìí
nínú èyí tí Kristi, e̩ran e̩bo̩ ìréko̩já a wa, rú ara Rè̩ lé̩bo̩.

Òun ni ò̩dó̩-àgùntàn tòótó̩
tí O ń kó è̩s̩è̩ ayé lo̩
E̩ni tí Ó fi ikú u Rè̩ pa ikú u wa ré̩
tí Ó sì fi Àjíǹde Rè̩ dá ìyè padà fún wa.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},

new Preface
{
    Season = "AJINDE (II)",
    Title = "Ayé tuntun nínú Krístì",
    Comment = "",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa kéde ògo ò Re̩, Olúwa, nígbà gbogbo
àti nípàtàkì ká máa yìn Ó̩ lógo ní àkókò yìí
nínú èyí tí Krístì, e̩ran e̩bo̩ ìréko̩já a wa, rú ara Rè̩ lé̩bo̩.

Nípa E̩ni tí àwo̩n o̩mo̩ ìmó̩lè̩ ń jí sí ìyè ayérayé
tí a sì s̩í ìlè̩kùn ìjo̩ba ò̩run sílè̩ fún àwo̩n onígbàgbó̩.
Ikú u Rè̩ ni Ó fi rà wá padà kúrò ló̩wó̩ ikú,
Àjíǹde Rè̩ sì ni àjíǹde wa sínú ìyè.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},

new Preface
{
    Season = "AJINDE (III)",
    Title = "Krístì tí Ó wà láàyè tí Ó sì ń bè̩bè̩ fún wa",
    Comment = "",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa kéde ògo ò Re̩, Olúwa, nígbà gbogbo
àti nípàtàkì ká máa yìn Ó̩ lógo ní àkókò yìí
nínú èyí tí Krístì, e̩ran e̩bo̩ ìréko̩já a wa, rú ara Rè̩ lé̩bo̩.

Krístì, E̩ni tí kò dé̩kun láti máa rú ara Rè̩ lé̩bo̩ nítorí i wa,
tó ń gba e̩jó̩ o̩ wa rò, 
tí Ó sì ń s̩e alágbàwí i wa nígbà gbogbo níwájú ù Re̩
Òun ni e̩ran e̩bo̩ náà tí kò ní kú mó̩,
Ò̩dó̩-àgùntàn tí a pa lé̩è̩kan s̩os̩o
tí Ó sì wà láàyè títí láé.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},

new Preface
{
    Season = "AJINDE (IV)",
    Title = "Ìràpadà gbogbo àgbáyé nípasè̩ ohun-ìjìnlè̩ àjíǹde",
    Comment = "",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa kéde ògo ò Re̩, Olúwa, nígbà gbogbo
àti nípàtàkì ká máa yìn Ó̩ lógo ní àkókò yìí
nínú èyí tí Krístì, e̩ran e̩bo̩ ìréko̩já a wa, rú ara Rè̩ lé̩bo̩.

Nínú un Krístì ni a ti pa ìjo̩ba è̩s̩è̩ ré̩
tí a so̩ ayé tó dàrú dò̩tun,
tí a sì dá iyì ayé tuntun padà fún wa.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},

new Preface
{
    Season = "AJINDE (V)",
    Title = "Krístì: àlùfáà àti e̩ran ìrúbo̩",
    Comment = "",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa kéde ògo ò Re̩, Olúwa, nígbà gbogbo
àti nípàtàkì ká máa yìn Ó̩ lógo ní àkókò yìí
nínú èyí tí Krístì, e̩ran e̩bo̩ ìréko̩já a wa, rú ara Rè̩ lé̩bo̩.

Bí Krístì s̩e rú ara Rè̩ lé̩bo̩ lórí àgbélébùú
Ó s̩e às̩epé àwo̩n ìrúbo̩ àtijó̩,
bí Ó s̩e fi ara Rè̩ lé O̩ ló̩wó̩ fún ìgbàlà wa
Ó fi ara Rè̩ hàn gé̩gé̩ bí àlùfáà, 
gé̩gé̩ bíi pe̩pe̩ 
àti gé̩gé̩ bíi ò̩dó̩-àgùntàn ìrúbo̩.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},
new Preface
{
    Season = "ÌGÒKÈ RẸ Ò̩RUN (I)",
    Title = "Ohun-ìjìnlè̩ Ìgòkè Rẹ Ò̩run",
    Comment = "A ń lo Orin-Ìyìn yìí ní o̩jó̩ o̩dún Ìgòkè Rẹ Ò̩run Oluwa wa. A tún lè lòó nínú Mísà tó wà láàárín o̩dún yìí àti O̩duń Ìsò̩kalè̩ È̩mí Mímó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

(Lónìí) Olúwa Jésù, O̩ba ògo, as̩é̩gun è̩s̩è̩ àti ikú 
gòkè lo̩ sí ò̩run, bí àwo̩n ángé̩lì ti ń wò tìyanu tìyanu.
Òun ni alágbàwí ènìyàn àti O̩ló̩run, 
Olùdájó̩ ayé àti Olúwa àwo̩n o̩mo̩ ogun,
Ó gòkè, kì í s̩e láti kò̩ wá sílè̩̀ ní ipò è̩s̩e̩ wa, 
bí kò s̩e pé, kí àwa tí a jé̩ è̩ya Rè̩, 
lè ní ìrètí láti tè̩lé E 
dé ibi tí Òun tíí s̩e olórí àti ìpílè̩s̩è̩ e̩ wa ti ko̩já lo̩.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÌGÒKÈ RẸ Ò̩RUN (II)",
    Title = "Ohun-ìjìnlè̩ Ìgòkè Rẹ Ò̩run",
    Comment = "A ń lo Orin-Ìyìn yìí ní o̩jó̩ o̩dún Ìgòkè Rẹ Ò̩run Oluwa wa. A tún lè lòó nínú Mísà tó wà láàárín o̩dún yìí àti O̩duń Ìsò̩kalè̩ È̩mí Mímó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩,
ojús̩e wa àti orísun ìgbàla wa ni,
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Kristi Olúwa wa.

E̩ni tí Ó farahan àwo̩n o̩mo̩-è̩yin Rè̩ ní gbangba
lé̩yìn àjíǹde Rè̩, 
tí Ó gòkè re ò̩run ní ìs̩ojú u wo̩n,
làti lè so̩ wa di alábàápín nínú ìwà O̩ló̩run Rè̩.

Nítorí náà, pè̩lú è̩kúnré̩ré̩ ayò̩ Àjíǹde
gbogbo è̩dá ayé àti orílè̩-èdè ń yò̩ nínú ìyìn Re̩,
àwo̩n agbára ò̩run pàápàá, àti ogúnló̩gò̩ àwo̩n ángé̩lì,
ń jùmò̩ ko̩rin ògo ò Re̩ bí wó̩n ti ń wí láìsinmi pé:"
},
new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (I)",
    Title = "Ohun-ìjìnlè̩ Àjíǹde àti Àwo̩n Ènìyàn O̩ló̩run",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Krístì Olúwa wa.

Àgbàyanu ni is̩é̩ tí Ó s̩e nípa ohun-ìjìnlè̩ ti àjíǹde,
èyí tí Ó fi dá wa nídè kúrò nínú àjàgà è̩s̩è̩ àti ikú,
tí Ó sì pè wá sínú ògo yìí,
èyí tó so̩ wá di
ìran tí a yàn,
àlùfáà ti ìdílé O̩ba, 
orílè̩-èdè mímó̩, 
àti ènìyàn tí a yà só̩tò̩,
làti máa kéde àwo̩n agbára ńlá à Re̩ níbi gbogbo,
nítorí tí O ti pè wá jáde kúrò nínú òkùnkùn
sínú ìmó̩lè̩ àgbàyanu ùn Re̩.

Nítorí náà, 
pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì,
pè̩lú àwo̩n ìté̩ àti agbára,
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run 
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (II)",
    Title = "Ohun-ìjìnlè̩ ti Ìgbàlà",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Krístì Olúwa wa.

Nínú àánú Rè̩ fún àìs̩edédé àwa ènìyàn,
Ó re̩ ara Rè̩ sílè̩, a sì bí I láti inú Wúndíá:
nípa ìjìyà àgbélébùú, 
Ó gbà wá là kúro nínú ikú àìnípè̩kun,
bí Ó sì ti jíǹde kúrò nínú òkú,
Ó fún wa ní ìyè àìnípè̩kun.

Nítorí náà, 
pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì,
pè̩lú àwo̩n ìté̩ àti agbára,
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run 
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (III)",
    Title = "Ìgbàlà Àwa È̩dá Nípa Ènìyàn Kan Bíi Tiwa",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Àwa mò̩ pé ó wà ní ìkáwó̩ ògo ńlá à Re̩,
làti dìde fún ìrànló̩wó̩ àwa ènìyàn e̩lé̩ran ara
pè̩lú ìwà O̩ló̩run ùn Re̩,
atí láti s̩e ètò àtúns̩e láti inú e̩ran ara ènìyàn fúnrarè̩,
pé kí ohun tó fa ìs̩ubú u wa, 
lè padà wá di orísun ìgbàlà fún wa
nípasè̩ Krístì Olúwa wa.

Nípa e̩ni tí e̩gbé̩ ogun àwo̩n ángé̩lì ń foríbalè̩ fún o̩láńlá à Re̩,
tí wó̩n ń yò̩ níwájú ù Re̩ títí ayérayé.

Àwa ń bè̩ Ó̩,
kí O kà wá ye̩ láti da ohùn wa pò̩ pè̩lú tiwo̩n
bi a tí ń ko̩ orin ìyìn Re̩ láìsinmi pé:"
},
new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (IV)",
    Title = "Ìtàn Ìgbàlà",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Krístì Olúwa wa.

E̩ni tí Ó fi ìbí i Rè̩ ra è̩dá ènìyàn padà kúrò nínú ìs̩ubú,
Ó fi ìjìyà a Rè̩ pa è̩s̩e̩ wa ré̩,
Ó fi Àjíǹde Rè̩ kúrò nínú òkú s̩í ò̩nà ìyè àìnípè̩kun,
Ó sì fi ìgòke Rè̩ lo̩ sí ò̩dò̩ Ìwo̩ Baba 
s̩í àwo̩n ìlè̩kùn ò̩run sílè̩.

Nítorí náà, 
pè̩lú e̩gbé̩ ogun àwo̩n ángé̩lì 
àti àwo̩n ènìyàn mímó̩
àwa ń ko̩ orin ìyìn sí O̩,
a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (V)",
    Title = "Ìs̩è̩dá",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Ìwo̩ tí O s̩è̩dá ohun gbogbo tó wà láyé,
tí O sì s̩èto ìyípadà ìgbà àti àkókò;
O dá ènìyàn ní àwòrán ara à Re̩
O si fi í s̩e olórí gbogbo ayé nínú àgbàyanu rè̩,
làti máa s̩e àkóso ohun gbogbo tí O ti dá ní orúko̩ ò̩ Re̩
kí ó sì máa yìn Ó̩ ní gbogbo ìgbà nínú àwo̩n is̩é̩ ńlá à Re̩
nípasè̩ Krístì Olúwa wa.

Nítorí náà, pè̩lú gbogbo àwo̩n ángé̩lì,
àwa ń yìn Ó̩,
a sì ń fi ayò̩ kéde ògo ò Re̩ pé:"
},

new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (VI)",
    Title = "Ìlérí Àjíǹde Ayérayé",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nínú E̩ni tí a wà láàyè, tí a ń rìn kiri, tí a sì wà,
àti nísinsìnyí bí ìs̩e wa nínú e̩ran ara yìí, 
àwa ń rí o̩wó̩ ìké̩ è̩ Rè̩ ní ara wa ní ojoojúmó̩
a sì tún ní ìlérí ìyè àìnípè̩kun ní ìkáwó̩.

Bí a s̩e gba àkó̩so èso ti È̩mí Mímó̩
nípasè̩ E̩ni tí Ó jí Jésù dìde kúrò nínú òkú
àwa ní ìrètí ìpín nínú àwo̩n ohun-ìjìnlè̩ àjíǹde ayérayé.

Nítorí náà, pè̩lú gbogbo àwo̩n ángé̩lì,
àwa ń yìn Ó̩,
a sì ń fi ayò̩ kéde ògo ò Re̩ pé:"
},

new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (VII)",
    Title = "Ìgbàlà Nípasè̩ Ìgbó̩ràn an Krístì",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nínú àánú ùn Re̩ Ìwo̩ fé̩ ayé tó bé̩è̩ gé̩ 
tí O fi rán O̩mo̩ ò̩ Re̩ sí wa gé̩gé̩ bí Olùgbàlà,
làti jé̩ kí Ó dàbíi tiwa nínú ohun gbogbo, àfi è̩s̩è̩,
pé kí Ìwo̩ lè fé̩ràn nínú un wa,
ohun tí inú ùn Re̩ dùn sí nínú O̩mo̩ ò̩ Re̩
E̩ni tí Ó fi ìgbo̩ràn àti ìte̩ríba dá àwo̩n è̩bùn Re̩ padà fún wa,
àwo̩n è̩bùn èyí tí a ti pàdánù nípa àìgbó̩ràn àti è̩s̩e̩ wa.

Nítorí náà, Olúwa, 
pè̩lú gbogbo àwo̩n ángé̩lì àti àwo̩n ènìyàn mímó̩
ni àwa ń jé̩wó̩ ò̩ Re̩,
bí a ti ń fi ayò̩ wípé:"
},

new Preface
{
    Season = "Ọ̀JỌ́-Ọ̀SẸ̀ LÁÀÁRÍN Ọ̀DÚN (VIII)",
    Title = "Ìjo̩ tí a Pèjo̩pò̩ Nínú Ìs̩ò̩kan ti Mé̩taló̩kan",
    Comment = "A lè lo Orin-Ìyìn yìí nínú Mísà gbogbo Ọ̀jọ́-Ọ̀sẹ̀ láàárín Ọ̀dún tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nígbà kúgbà tí àwo̩n o̩mo̩ ò̩ Re̩ bá s̩áko lo̩ nínú è̩s̩è̩,
Ìwo̩ kó wo̩n jo̩pò̩ lé̩è̩kan síi só̩dò̩ Re̩
nípa È̩jè̩ O̩mo̩ ò̩ Re̩ àti agbára È̩mí Mímó̩,
pé, kí àwo̩n ènìyàn tí a ti kójo̩pò̩ nínú ìs̩ò̩kan È̩mí Mímó̩
lè hàn gé̩gé̩ bí Ìjo̩, 
èyí tí a ti so̩ di ara Krístì àti àgó̩ o̩ ti È̩mí Mímó̩
fún ìyìn àti ògo o̩gbó̩n ńlá à Re̩.

Nítorí náà, 
ní ìs̩ò̩kan pè̩lú e̩gbé̩ ako̩rin àwo̩n ángé̩lì 
ni àwa ń yìn Ó̩ tí a si fi ayò̩ kéde ògo ò Re̩ pé:
" 
},
new Preface
{
    Season = "YÚKARISTÍ MÍMÓ (I)",
    Title = "Ìrúbo̩ àti Sákrámé̩ńtì Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà ti Oúnje̩-alé̩ Olúwa. A sì tún lè lòó fún o̩dún Ara àti È̩je̩ Krístì (Corpus Christi) àti gbogbo o̩dún Ara Olúwa tí a ń s̩e.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Krístì Olúwa wa.

Òun ni Àlùfáà tòótó̩ àti ayérayé,
tí Ó s̩e ìfiló̩lè̩ irúfé̩ e̩bo̩ ayérayé yìí
tí Ó fi Ara Rè̩ jì lákò̩ó̩kó̩ gé̩gé̩ bí e̩ran e̩bo̩ ìràpadà
tí Ó sì pa á lás̩e̩ ká máa s̩e e̩bo̩ yìí ní ìrántí Òun.
Bí a s̩e ń je̩ e̩ran Ara Rè̩ tí Ó fi rúbo̩ fún wa, ni a ń fún wa lókun,
bí a sì s̩e ń mu È̩je̩ Rè̩ ti Ó tasílè̩ fún wa, ni a ń wè̩ wá mó̩.

Nítorí náà, 
pè̩lú àwo̩n ángé̩lì àti àwo̩n olórì ángé̩lì 
pè̩lú àwo̩n ìté̩ àti agbára 
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run 
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "YÚKARISTÍ MÍMÓ (II)",
    Title = "Àwo̩n Èso Yúkaristí Mímó̩",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà ti o̩dún Ara àti È̩je̩ Krístì (Corpus Christi) àti gbogbo o̩dún Ara Olúwa tí a ń s̩e.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Krístì Olúwa wa.

Níbi oúnje̩-alé̩ ìke̩yìn pè̩lú àwo̩n Àpóstóli Rè̩,
Ó s̩e ìfiló̩lè̩ ìrántí ìgbàlà a ti àgbélébùú fún àwo̩n ìran tó ń bò̩,
Ó fi ara Rè̩ jì fún O̩ gé̩gé̩ bí ò̩dó̩-àgùntàn aláìlábàwó̩n,
gé̩gé̩ bí ìyìn pípé,
àti gé̩gé̩ bí e̩bo̩ tí inú ùn Re̩ dùn sí.

Bí O s̩e ń fi okun fún àwo̩n onígbàgbó̩ ò̩ Re̩ nípa e̩bo̩ ìjìnlè̩ yìí
ni O ń yà wó̩n sí mímó̩,
kí ìran è̩dá ènìyàn jákèjádò àgbáyé
lè máa gbé lábé̩ òye ìgbàgbó̩ kan náà,
kí wó̩n sì máa wà ní ìré̩pò̩ nínú okun ìfé̩ kan náà.

Nísinsìnyí, 
àwa náà ń fi ayò̩ súnmó̩ pe̩pe̩ Sákrámé̩ńtì àgbàyanu yìí
pé, ká ba lè pín nínú adùn oore-ò̩fé̩ è̩ Re̩,
ká sì lè dé ibi òye àwo̩n ohun ò̩run tí wó̩n dúró fún.

Nítorí náà, 
gbogbo àwo̩n è̩dá ní ò̩run àti ní ayé
ń bo̩lá fún O̩ pè̩lú orin tuntun,
àwa náà pàápàá pè̩lú gbogbo e̩gbé̩ ogun àwo̩n ángé̩lì
ń kéde ògo ò Re̩ tí a sì ń wí láìsinmi pé:"
},
new Preface
{
    Season = "Ọ̀DÚN MÀRÍÀ WÚNDÍÁ MÍMÓ̩ (I)",
    Title = "Ipò Màríà Wúndíá Mímó̩ gé̩gé̩ bí Ìyá",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Màríà Wúndíá Mímó̩, nínú èyí tí a ń dárúko̩ Ọ̀dún Màríà pàtàkì tí a ń s̩e.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo,
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:
àti láti máa fi o̩lá, ìbùkún àti ògo fún orúko̩ ò̩ Re̩ ní o̩jó̩ ayé̩ye̩ (N.) Màríà alábùkún-fún, láéláé Wúndíá.

E̩ni tó lóyún O̩mo̩ bíbí ì Re̩ kan s̩os̩o nípa ìs̩íjibò È̩mí Mímó̩,
láìso̩ ògo wúndíá a rè̩ nù,
ó bí Jésù Krístì Olúwa wa, E̩ni tíí s̩e ìmó̩lè̩ ayérayé.

Nípasè̩ e̩ Rè̩ ni àwo̩n ángé̩lì ń yin o̩láńlá à Re̩,
tí àwo̩n ìté̩ te̩ríba, tí àwo̩n agbára sì ń wárìrì níwájú ù Re̩.

Ò̩run àti àwo̩n agbára ò̩run àti àwo̩n séráfù mímó̩
wó̩n ń jùmò̩ fi ayò̩ ń sìn Ó̩.

Àwa ń bè̩ Ó̩, 
kí àwa náà lè da ohùn wa pò̩ s̩ò̩kan pè̩lúu wo̩n
bí a ti ń fi ìrè̩lè̩ kéde pé:"
},

new Preface
{
    Season = "Ọ̀DÚN MÀRÍÀ WÚNDÍÁ MÍMÓ̩ (II)",
    Title = "Ìjo̩ ń fi ò̩rò̩ Màríà yin O̩ló̩run",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Màríà Wúndíá Mímó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa yin agbára ńlá à Re̩ nínú orin ìyìn àwo̩n ènìyàn mímó̩,
nipàtàkì bí a s̩e ń s̩e ayé̩ye̩ ìrántí i Màríà Wúndíá Mímó̩,
làti máa kéde àánú ùn Re̩ bí a ti ń lo orin ìyìn Màríà.

Nítòótó̩, títí dé òpin ayé ni Ìwo̩ ń s̩e ohun ribiribi
tí O sì ń fi ò̩pò̩ àánú ùn Re̩ hàn láti ìran dé ìran;
Ìwo̩ bojú wo ìrè̩lè̩ o̩mo̩bìnrin ò̩dò̩ Re̩

O sì tipasè̩ e̩ rè̩ fún wa ní As̩è̩dá ìgbàlà o̩mo̩ ènìyàn,
E̩ni tí Í s̩e O̩mo̩ ò̩ Re̩, Jésù Krístì Olúwa wa.

Nípasè̩ E̩ni tí àwo̩n e̩gbé̩ ogun àwo̩n ángé̩lì ń te̩ríba fún o̩láńlá à Re̩,
tí wó̩n sì ń yò̩ níwájú ù Re̩ títí láé.

Àwa ń bè̩ Ó̩, 
kí àwa náà lè da ohùn wa pò̩ s̩ò̩kan pè̩lúu wo̩n
bí a ti ń fi ayò̩ kéde pé:"
},
new Preface
{
    Season = "Ọ̀DÚN ÀWỌN ÀPÓSTÓLÌ (I)",
    Title = "Àwọn Àpóstólì, Olùs̩ó̩ Àgùtàn Àwọn Ènìyàn O̩ló̩run",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Àpóstólì, nípàtàkì Pétérù àti Pó̩ò̩lù.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Ìwo̩ ni Olùs̩ó̩-àgùntàn ayérayé tí kò fi agbo Rè̩ sílè̩ rí láìní olùtó̩jú
Ìwo̩ ń lo Àwọn Àpóstólì láti tó̩jú u wa
tí O sì ń tipa wó̩n dáàbò bò wá.

Ìwo̩ ni O yàn wó̩n ní olùs̩ó̩ agbo àgùntàn Rè̩ 
làti máa bá O̩mo̩ ò̩ Re̩ s̩is̩é̩
àti láti máa tó̩ wa só̩nà láti ipò o wó̩n ní ò̩run.

Nítorí náà, 
pè̩lú Àwọn ángé̩lì àti Àwọn olórì ángé̩lì 
pè̩lú Àwọn ìté̩ àti Àwọn agbára 
àti pè̩lu gbogbo Àwọn e̩gbé̩ ogun ò̩run 
ni àwa ń ko̩ orin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀DÚN ÀWỌN ÀPÓSTÓLÌ (II)",
    Title = "Ìjé̩rìí àti Ìpìlè̩ ti Ìjo̩ nínú Àwọn Àpóstólì",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Àpóstólì àti Ajíyìnrere.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé
nípasè̩ Krístì Olúwa wa.

Ìwo̩ tí fi ìpílè̩s̩è̩ Ìjo̩ ò̩ Re̩ lélè̩ lórí Àwọn Àpóstólì
kí ó lè dúró s̩ins̩in títí láé 
gé̩gé̩ bí àmì ìwà mímó̩ ò̩ Re̩ tí kìí yè̩
tí a lè rí ní ayé yìí
àti gé̩gé̩ bí orísun è̩kó̩ àtò̩runwá fún gbogbo ènìyàn.

Nítorí náà, 
nísinsìnyí àti títí ayé àìnípè̩kun,
pè̩lú e̩gbé̩ ogun Àwọn ángé̩lì,
ni àwa ń fi o̩kàn ìgbàgbó̩ ko̩ orin ìyìn sí O̩, 
tí a ń kígbe lóhùn rara
tí a sì ń wí láìsinmi pé:"
},
new Preface
{
    Season = "Ọ̀DÚN ÀWỌN ÈNÌYÀN MÍMÓ̩ L’Ó̩KÙNRIN L’Ó̩BÌNRIN (I)",
    Title = "Ògo ti Àwọn Ènìyàn Mímó̩",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Ènìyàn Mímó̩ l’Ó̩kùnrin l’Ó̩bìnrin, nípàtàkì Àwọn tí kò bá ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Àwa ń fi ògo fún O̩ nínú agbo Àwọn Ènìyàn Mímó̩ ò̩ Re̩
ògo is̩é̩ e̩ wó̩n ni às̩epé Àwọn è̩bùn Re̩,
Ìwo̩ fi ìgbésí ayé e wó̩n s̩e àpe̩e̩re̩ fún wa,
Ìwo̩ fi wó̩n s̩e ò̩re̩ wa bí a s̩e ń pín nínú is̩é̩ e̩ wó̩n
Ìwo̩ fún wa ní agbára àti ààbò bí wó̩n ti ń gbàdúrà fún Ìjo̩ ò̩ Re̩
e̩gbé̩ ńlá a ti Àwọn ajé̩rìí Re̩ yìí ni ń fún wa ní ìs̩írí láti jagunmólú
àti láti bá wó̩n pín nínú èrè ògo àìnípè̩kun
nípasè̩ Krístì Olúwa.

Nítorí náà, 
pè̩lú Àwọn ángé̩lì àti Àwọn olórì ángé̩lì 
pè̩lú ogúnló̩gò̩ Àwọn Ènìyàn Mímó̩ 
ni àwa ń ko̩rin ìyìn sí O̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀DÚN ÀWỌN ÈNÌYÀN MÍMÓ̩ L’Ó̩KÙNRIN L’Ó̩BÌNRIN (II)",
    Title = "Ìs̩é̩ Àwọn Ènìyàn Mímó̩",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Ènìyàn Mímó̩ l’Ó̩kùnrin l’Ó̩bìnrin, nípàtàkì Àwọn tí kò bá ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nínú è̩rí àgbàyanu Àwọn Ènìyàn Mímó̩ ò̩ Re̩
Ìwo̩ ń mú Ìjo̩ ò̩ Re̩ gbèrú síi nínú agbára ò̩tun
Ó sì ń fún wa ní ìdánilójú Àwọn àmì ìfé̩ è̩ Re̩.

Wó̩n ń fún wa ní ìs̩írí pè̩lú ayé e wó̩n
wó̩n sì ń fi àdúra wó̩n ràn wá ló̩wó̩ nínú un gbogbo ohun tí a ń s̩e
kí Àwọn ìdánilójú ìjìnlè̩ ìgbàlà Re̩ lè wá sí ìmús̩e̩.

Nítorí náà, Olúwa, 
pè̩lú gbogbo Àwọn ángé̩lì àti Àwọn Ènìyàn Mímó̩
ni àwa ń jé̩wó̩ ò̩ Re̩,
bí a ti ń fi ayò̩ wípé:"
},
new Preface
{
    Season = "Ọ̀DÚN ÀWỌN AJÉ̩RÌÍKÚ (I)",
    Title = "Ààmi àti Àpe̩e̩re̩ Àwọn Ajé̩rìí-Ikú",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Ajé̩rìíkú, nípàtàkì Àwọn tí kò bá ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Ni títè̩lé àpe̩e̩re̩ Krístì,
Àwọn Ajé̩rìí-Ikú ù Re̩ jé̩wó̩ ògo orúko̩ ò̩ Re̩
wó̩n sì fi ìyanu is̩é̩ o̩wó̩ ò̩ Re̩ hàn
nípa ìtàjè̩sílè̩ Rè̩.

Ikú u wó̩n fi agbára à Re̩ hàn nínú àìlera ara wa,
Ìwo̩ máa ń yan Àwọn aláìlera 
tí O sì ń fún wó̩n ní agbára àti ìgboyà
làti jé̩rìí sí O̩ nípasè̩ Krístì Olúwa wa.

Nítorí náà, 
pè̩lú Àwọn agbára ò̩run
ni àwa ń sìn Ó̩ nígbà gbogbo ní ayé, 
tí a sì ń ko̩rin ògo o̩láńlá à Re̩ láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀DÚN ÀWỌN AJÉ̩RÌÍKÚ (II)",
    Title = "Àwọn Is̩é̩ Àgbàyanu Olúwa Nínú Ìs̩é̩gun Ikú",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Ajé̩rìíkú, nípàtàkì Àwọn tí kò bá ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Olúwa,
Ìwo̩ ń fi ògo fún orúko̩ ò̩ Re̩ 
nígbà tí a bá ń yin Àwọn Ènìyàn Mímó̩,
gbogbo ohun tó jé̩mó̩ ìjìyà wó̩n jé̩ àgbàyanu is̩é̩ agbára à Re̩:
nínú àánú ùn Re̩, 
O fi agbára kún ìgbàgbó̩ wó̩n,
O fi ìdúrós̩ins̩in kún ìfaradà wó̩n
O sì fún wó̩n ní ìs̩é̩gun nínú ìnúnibíni dé ojú ikú
nípasè̩ Krístì Olúwa wa.

Nítorí náà, 
gbogbo Àwọn è̩dá ní ò̩run àti ní ayé
ń bo̩lá fún O̩ pè̩lú orin tuntun,
àwa náà pàápàá pè̩lú gbogbo e̩gbé̩ ogun Àwọn ángé̩lì
ń kéde ògo ò Re̩ tí a sì ń wí láìsinmi pé:"
},
new Preface
{
    Season = "Ọ̀DÚN ÀWỌN OLÙDARÍ ÌJỌ",
    Title = "Àwọn Olùdarí Mímó̩ Nínú Ìjọ",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Olùkó̩-Ìjọ, nípàtàkì Àwọn tí kò bá ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé,
nípasè̩ Krístì Olúwa wa.

Ìwo̩ fún Ìjọ ò̩ Re̩ ni ayò̩ láti s̩e ayé̩ye̩ Ọ̀dún (N) Mímó̩. 
Ìwo̩ fún wa ní ìs̩írí pè̩lú ayé mímó̩ Rè̩,
Ìwo̩ fi ìwàásù Rè̩ kó̩ wa lé̩kò̩ó̩,
Ìwo̩ sì ń dáàbò bò wa nípa è̩bè̩ Rè̩ ló̩dò̩ Re̩ fún wa.

Nítorí náà, 
pè̩lú e̩gbé̩ ogun Àwọn ángé̩lì àti Àwọn ènìyàn mímó̩
àwa ń ko̩ orin ìyìn sí O̩,
a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "Ọ̀DÚN MÀRÍÀ MÍMÓ ÀTI OLÙFÒ̩KÀNSÌN",
    Title = "Ààmì Ìyàsó̩tò̩ Fún O̩ló̩run",
    Comment = "A ń lo Orin-Ìyìn yìí nínú Mísà fún gbogbo Ọ̀dún Àwọn Wúndíá àti Olùfò̩kànsìn, nípàtàkì Àwọn tí kò bá ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nínú Àwọn Ènìyàn Mímó̩ ò̩ Re̩ 
tí wó̩n fi ara wó̩n jì fún Krístì nítorí Ìjọba Ò̩run,
ó tó̩ ká máa fi ìyìn fún O̩ fún ìpèsè Rè̩
nínú èyí tí O dá ìwà mímó̩ ìpílè̩s̩è̩ ti è̩dá ènìyàn padà
tí O sì fún un ní ìtó̩wò Àwọn è̩bùn
tí yóò jé̩ tirè̩ nínú ayé tó ń bò̩.

Nítorí náà, 
pè̩lú gbogbo Àwọn ángé̩lì àti Àwọn ènìyàn mímó̩
ni àwa ń da ohùn wa pò̩ s̩ò̩kan láti yìn Ó̩, 
tí a sì ń wí láìsinmi pé:"
},
new Preface
{
    Season = "ÀWỌN Ọ̀JỌ́ LÁÀÁRÍN Ọ̀SẸ̀ (I)",
    Title = "Ìmúpadàbò̩-sípò Ohun Gbogbo Nínú Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí fún Àwọn Mísà tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nínú E̩ni tí Ó wù ó̩ láti so̩ ohun gbogbo dò̩tun 
tí Ó sì pín fún gbogbo wa nínú è̩kúnré̩ré̩ o̩rò̩ o̩ Rè̩. 
Bí ó tilè̩ jé̩ pé Ó ní ìwà O̩ló̩run, Ó bó̩ ògo Rè̩ sílè̩, 
àti nípa títa È̩je̩ Rè̩ sílè̩ lórí àgbélébùú
Ó mú àlàáfíà Rè̩ wá sí ayé. 
Nítorí èyí ni a gbé E ga ju gbogbo è̩dá lo̩, 
tí Ó sì di orísun ìyè àìnípè̩kun 
fún gbogbo Àwọn tí wó̩n ń sìn Ín.

Nítorí náà, 
pè̩lú Àwọn ángé̩lì àti Àwọn olórì ángé̩lì 
pè̩lú Àwọn ìté̩ àti agbára 
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run 
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÀWỌN Ọ̀JỌ́ LÁÀÁRÍN Ọ̀SẸ̀ (II)",
    Title = "Ìgbàlà Nípasè̩ Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí fún Àwọn Mísà tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Ní inú rere è Re̩ ni Ìwo̩ ti dá ènìyàn, 
ní òdodo ò Re̩ ni Ìwo̩ ti dá a lé̩bi, 
s̩ùgbó̩n nínú àánú ùn Re̩ ni Ìwo̩ ti rà á padà, 
nípasè̩ Krístì Olúwa wa.

Nínú E̩ni tí Àwọn ángé̩lì ń yin o̩láńlá à Re̩,
tí Àwọn ogun ò̩run ń te̩ríba,
tí Àwọn agbára náà sì ń wárìrì níwájú ù Re̩.

Ò̩run àti Àwọn agbára ò̩run
pè̩lú Àwọn Séráfù mímó̩ ń fi ayò̩ yìn Ó̩.

Àwa ń bè̩ Ó̩, 
jé̩ ká lè da ohùn wa pò̩ s̩ò̩kan pè̩lúu wó̩n
nínú orin ìrè̩lè̩
bí a ti ń wípé:"
},

new Preface
{
    Season = "ÀWỌN Ọ̀JỌ́ LÁÀÁRÍN Ọ̀SẸ̀ (III)",
    Title = "Ìyìn O̩ló̩run Fún Ìs̩è̩dá àti Ìràpadà Ọ̀mo̩ Ènìyàn",
    Comment = "A ń lo Orin-Ìyìn yìí fún Àwọn Mísà tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Nípasè̩ O̩mo̩ ò̩ Re̩ àyànfé̩ ni Ìwo̩ ti s̩è̩dá iran è̩dá ènìyàn bíi tìre̩. 
Nípasè̩ E̩ Rè̩ náà ni Ìwo̩ tún mú wa padà bò̩ sí àwòrán Àn Re̩. 
Nítorí náà è̩tó̩ ò̩ Re̩ ni kí gbogbo è̩dá máa te̩ríba fún O̩,
kí gbogbo Àwọn ènìyàn tí Ìwo̩ ti ràpadà máa fi ìyìn fún O̩
kí Àwọn ènìyàn mímó̩ ò̩ Re̩ sì máa fi o̩kàn kan bùkún fún O̩.

Pè̩lú gbogbo Àwọn ángé̩lì ni àwa náà
ń fi ìyìn fún O̩, 
tí a ń fi ayò̩ jé̩wó̩ orúko̩ ò̩ Re̩ ní gbogbo ìgbà 
bí a ti ń wípé:"
},
new Preface
{
    Season = "ÀWỌN Ọ̀JỌ́ LÁÀÁRÍN Ọ̀SẸ̀ (IV)",
    Title = "Ìyìn: È̩bùn O̩ló̩run",
    Comment = "A ń lo Orin-Ìyìn yìí fún Àwọn Mísà tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé.

Bí ó tilè̩ jé̩ pé ìyin wa kò lè fi kún ògo ò Re̩, 
síbè̩ àníyàn wa láti dúpé̩ ló̩wó̩ ò̩ Re̩ jé̩ oore è Re̩ sí wa. 
Ìyin wa kò fi nǹkankan kún o̩láńlá à Re̩, 
dípo bé̩è̩, 
s̩e ni ó ń fún wa ní àǹfààní fún ìgbàlà, 
nípasè̩ Krístì Olúwa wa.

Nítorí náà, 
ní ìs̩ò̩kan pè̩lú e̩gbé̩ ako̩rin Àwọn ángé̩lì 
ni àwa ń yìn Ó̩ tí a sì fi ayò̩ kéde ògo ò Re̩ pé:"
},

new Preface
{
    Season = "ÀWỌN Ọ̀JỌ́ LÁÀÁRÍN Ọ̀SẸ̀ (V)",
    Title = "Ìkéde Ohun-Ìjìnlè̩ Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí fún Àwọn Mísà tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩,
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:
nípasè̩ Krístì Olúwa wa.

Pè̩lú ìfé̩ ni àwa ń s̩e àjo̩yò̩ ìrántí ikú u Rè̩. 
Pè̩lú ìgbàgbó̩ ààyè ni àwa ń kéde Àjíǹde Rè̩. 
Pè̩lú ìrètí s̩ins̩in ni àwa ń dúró de ìpadàbo̩ Rè̩ nínú ògo.

Nítorí náà, 
pè̩lú gbogbo Àwọn ángé̩lì àti Àwọn ènìyàn mímó̩
ni àwa ń da ohùn wa pò̩ s̩ò̩kan láti yìn Ó̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÀWỌN Ọ̀JỌ́ LÁÀÁRÍN Ọ̀SẸ̀ (VI)",
    Title = "Ohun Ìjìnlè̩ Ìràpadà Nínú Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí fún Àwọn Mísà tí kò ní Orin-Ìyìn tiwo̩n.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, Baba Mímó̩.
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
nípasè̩ O̩mo̩ ò̩ Re̩ àyànfé̩, Jésù Krístì.

Ò̩rò̩ Rè̩, nípasè̩ E̩ni tí O dá ohun gbogbo
tí O rán gé̩gé̩ bí Olùgbàlà àti Olùràpadà a wa,
tí a bí láti inú Wúndíá nípasè̩ È̩mí Mímó̩.

Ó mú ìfé̩ è̩ Rè̩ s̩e̩ 
Ó sì jèrè Ìjo̩ Ènìyàn Mímó̩ kan fún O̩,
Ó na apá Rè̩ bí Ó s̩e ń jìyà ikú lórí àgbélébùú
làti já ìdè ikú 
àti láti fi ìyè Àjíǹde hàn.

Nítorí náà
pè̩lú Àwọn ángé̩lì àti gbogbo Àwọn ènìyàn mímó̩
ni àwa ń kéde ògo ò Re̩
tí a sì ń fi ohùn kan wípé:"
},
new Preface
{
    Season = "ÌKÚ ONÍGBÀGBÓ̩ (I)",
    Title = "Ìrètí Àjíǹde Nínú Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí fún Mísà Òkú Onígbàgbó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:
nípasè̩ Krístì Olúwa wa.

Nínú E̩ni tí ìrètí ìbùkún Àjíǹde ti tàn sí wa,
pé, kí Àwọn tí ìmò̩dájú ikú ti bànínújé̩
lè rí ìtùnù nípa ìlérí ayé àìnípè̩kun tí ń bò̩.

Olúwa, ní ti Àwa Onígbàgbó̩ ò̩ Re̩,
ìgbà kò tán, ó yípadà ni,
àti lé̩yìn ìgbà tí ibùgbé wa yìí bá padà di erùpè̩
a óò pèsè ibùgbé àìnípè̩kun fún wa ló̩run rere.

Nítorí náà, 
pè̩lú Àwọn ángé̩lì àti Àwọn olórì ángé̩lì 
pè̩lú Àwọn ìté̩ àti agbára 
àti pè̩lu gbogbo e̩gbé̩ ogun ò̩run 
ni àwa ń fi ayò̩ ko̩rin ògo ò Re̩, 
tí a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÌKÚ ONÍGBÀGBÓ̩ (II)",
    Title = "Krístì Kú Fún Ìyè Wa",
    Comment = "A ń lo Orin-Ìyìn yìí fún Mísà Òkú Onígbàgbó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:
nípasè̩ Krístì Olúwa wa.

E̩ni tí Ó fúnrarè̩ gba ikú
kí gbogbo wa báà lè bó̩ ló̩wó̩ ikú,
bé̩è̩ ni Ó yàn láti kú
ká ba lè máa wà láàyè fún O̩ nìkan títí láéláé.

Nítorí náà, 
pè̩lú e̩gbé̩ ako̩rin Àwọn ángé̩lì
àwa ń yìn Ó̩,
a sì ń wí pè̩lú ayò̩ pé:"
},

new Preface
{
    Season = "ÌKÚ ONÍGBÀGBÓ̩ (III)",
    Title = "Krístì, Ìgbàlà àti Ìyè Wa",
    Comment = "A ń lo Orin-Ìyìn yìí fún Mísà Òkú Onígbàgbó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:
nípasè̩ Krístì Olúwa wa.

Òun ni Olùgbàlà ayé,
Ìyè Ọ̀mo̩ Ènìyàn
àti Àjíǹde Àwọn Òkú.

Nípa E̩ni tí e̩gbé̩ ogun Àwọn ángé̩lì ń foríbalè̩ fún o̩láńlá à Re̩,
tí wó̩n ń yò̩ níwájú ù Re̩ títí ayérayé,

Àwa ń bè̩ Ó̩,
kí O kà wá ye̩ láti da ohùn wa pò̩ pè̩lúu tiwó̩n
bí a tí ń ko̩ orin ìyìn Re̩ láìsinmi pé:"
},
new Preface
{
    Season = "ÌKÚ ONÍGBÀGBÓ̩ (IV)",
    Title = "Ìgbé Ayé Ènìyàn Lo̩ Sí Inú Ògo Ti Ò̩run",
    Comment = "A ń lo Orin-Ìyìn yìí fún Mísà Òkú Onígbàgbó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:

Nípa agbára à Re̩ ni a bí wa,
nípa ìlànà Re̩ ni Ìwo̩ ń s̩àkóso wa,
nípa às̩e̩ è̩ Re̩ ni a padà sí ipò erùpè̩, 
nínú èyí tí a ti jáde wá nípa è̩s̩e̩ wa.

Nígbà tí Ìwo̩ bá sì fo̩n ìpè
a óò gbé Àwa tí a ti ràpadà nípa ikú O̩mo̩ ò̩ Re̩
dìde sí ògo ti Àjíǹde Rè̩.

Nítorí náà, 
pè̩lú e̩gbé̩ ogun Àwọn ángé̩lì 
àti Àwọn ènìyàn mímó̩
àwa ń ko̩ orin ìyìn sí O̩,
a sì ń wí láìsinmi pé:"
},

new Preface
{
    Season = "ÌKÚ ONÍGBÀGBÓ̩ (V)",
    Title = "Àjíǹde Wa Nípasè̩ Ìs̩é̩gun Krístì",
    Comment = "A ń lo Orin-Ìyìn yìí fún Mísà Òkú Onígbàgbó̩.",
    Text = @"Nítòótó̩ ó ye̩, ó sì tó̩, 
ojús̩e wa àti orísun ìgbàla wa ni, 
ká máa dúpé̩ ló̩wó̩ ò̩ Re̩, 
nígbà gbogbo àti níbi gbogbo, 
Olúwa, Baba Mímó̩, O̩ló̩run Olódùmarè àti ayérayé:

Bí ó tilè̩ jé̩ pé nípa às̩ìs̩e wa ni a ń s̩ègbé,
síbè̩síbè̩, nígbà tí agbára ikú bá bò wá mó̩lè̩ nítorí è̩s̩e̩ wa,
pè̩lú àánú àti oore-ò̩fé̩ è̩ Re̩
ni Ìwo̩ ń fi agbára Ìs̩é̩gun Ìràpadà Krístì 
pè wá padà sínú ìyè pè̩lúu Rè̩.

Nítorí náà, 
pè̩lú Àwọn agbára ò̩run
ni àwa ń sìn Ó̩ nígbà gbogbo ní ayé, 
tí a sì ń ko̩rin ògo o̩láńlá à Re̩ láìsinmi pé:"
},


            };

        }

        // Get filtered prefaces based on selected Eucharistic Prayer
        public static List<Preface> GetFilteredPrefaces(string selectedPrayerNumber = null)
        {
            var allPrefaces = GetPrefaces();
            
            if (string.IsNullOrEmpty(selectedPrayerNumber))
            {
                // Default: show only general prefaces (no PrayerNumber)
                return allPrefaces.Where(p => string.IsNullOrEmpty(p.PrayerNumber)).ToList();
            }
            
            // Check if this is a prayer with fixed preface (IV, VII, VIII, IX, X)
            if (HasFixedPreface(selectedPrayerNumber))
            {
                // Return empty list - fixed prefaces are handled separately
                return new List<Preface>();
            }
            
            // Check if this prayer has no preface (XI)
            if (HasNoPreface(selectedPrayerNumber))
            {
                // Return empty list - no preface section
                return new List<Preface>();
            }
            
            // For prayers I, III: show only general prefaces
            if (selectedPrayerNumber == "I" || selectedPrayerNumber == "III")
            {
                return allPrefaces.Where(p => string.IsNullOrEmpty(p.PrayerNumber)).ToList();
            }
            
            // For prayers II, V, VI: show prayer-specific + general prefaces
            if (selectedPrayerNumber == "II" || selectedPrayerNumber == "V" || selectedPrayerNumber == "VI")
            {
                var prayerSpecificPrefaces = allPrefaces.Where(p => p.PrayerNumber == selectedPrayerNumber).ToList();
                var generalPrefaces = allPrefaces.Where(p => string.IsNullOrEmpty(p.PrayerNumber)).ToList();
                
                // Prayer-specific prefaces appear first, then general prefaces
                var result = prayerSpecificPrefaces.Concat(generalPrefaces).ToList();
                return result;
            }
            
            // Default: return general prefaces
            return allPrefaces.Where(p => string.IsNullOrEmpty(p.PrayerNumber)).ToList();
        }

        // Check if prayer has fixed preface (no preface picker)
        public static bool HasFixedPreface(string prayerNumber)
        {
            var fixedPrefacePrayers = new[] { "IV", "VII", "VIII", "IX", "X" };
            return fixedPrefacePrayers.Contains(prayerNumber);
        }

        // Check if prayer has no preface section
        public static bool HasNoPreface(string prayerNumber)
        {
            return prayerNumber == "XI";
        }

        // Get fixed preface text for prayers IV, VII, VIII, IX, X
        public static Preface GetFixedPreface(string prayerNumber)
        {
            var allPrefaces = GetPrefaces();
            return allPrefaces.FirstOrDefault(p => p.PrayerNumber == prayerNumber && 
                                          string.IsNullOrEmpty(p.Season) && 
                                          string.IsNullOrEmpty(p.Title) && 
                                          string.IsNullOrEmpty(p.Comment));
        }
    }
}
