using System.Collections.Generic;
using System.Linq;
using YorubaCatholicHymn.Models;

namespace YorubaCatholicHymn.Data
{
    public static class EucharisticPrayerData
    {
        public static List<EucharisticPrayer> GetPrayers() => new List<EucharisticPrayer>
    {
        new EucharisticPrayer
        {
            Number = "I",
            Title = "Àdúrà Yukaristí kìnní",
            Season = "Àdúrà Yukaristí I",
            Comment = "The Priest alone recites:",
            Text = @"Baba aláàánú jùlo̩,
a ń gbàdúrà, a sì ń bè̩bè̩ pè̩lú ìrè̩lè̩,
nípasè̩ Jésù Kristì O̩mo̩ ò̩ Re̩ Olúwa wa,
kí O té̩wó̩gba àwo̩n o̩re̩ wa yìí,
kí O sì yà [red]✠[/red] wó̩n sí mímó̩;
àwo̩n o̩re̩ wò̩nyí, ìrubo̩ mímó̩ àti aláìlábàwó̩n,
èyí tí a rú lé̩bo̩ sí O̩,
nípàtàkì, fún Ìjo̩ mímó̩ ò̩ Re̩ Kátólíkì.
Jò̩wó̩ fún un ní àlàáfíà,
kí O pa á mó̩,
kí O mú u wà ní ìré̩pò̩
kí O sì máa darí i rè̩ ní gbogbo àgbáyé:
pè̩lu o̩mo̩-ò̩dò̩ Re̩ Pápà a wa [red][b]N.[/b][/red] àti Bís̩ó̩ò̩bù u wa, [red][b]N.[/b][/red]
àti gbogbo àwo̩n tí wó̩n ti ń di òtító̩ ìgbàgbó̩ mú,
tí wó̩n sì ń fi ìgbàgbó̩ o̩ Kátólíki àti Àpóstólíkì náà
tí wó̩n ti gbà kó̩ àwo̩n ènìyàn.

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b](N.[/b][/red] àti [red][b]N.)[/b][/red]
àti gbogbo àwo̩n tí wó̩n péjo̩ síhìn ín,
tí ìgbàgbó̩ àti ìfo̩kànsìn wo̩n jé̩ mímò̩ fún O̩,
àwo̩n e̩ni tí a ń rú e̩bo̩ ìyìn yìí fún,
tàbí àwo̩n tí wó̩n ń rú e̩bo̩ náà fún ara wo̩n
àti fún àwo̩n tó s̩ò̩wó̩n fún wo̩n,
fún ìràpadà è̩mí wo̩n,
ní ìrètí ìwòsàn àti ara líle,
tí wó̩n sì ń júbà Re̩,
Ìwo̩ O̩ló̩run ayérayé,
alààyè, àti òtító̩.
",
            CommunicantesList = new List<Communicantes>
            {
                new Communicantes
{
    Season = "Usual Form",
    Comment = "Àwo̩n àdúrà fún àwo̩n o̩dún pàtàkì",
    Text = @"Ní ìdàpò̩ pè̩lú gbogbo Àwọn tí a ń fi àyé̩sí s̩e ìrántí wó̩n,
ní pàtàkì Màríà, láéláé Wúndíá ológo,
Ìyá O̩ló̩run àti Olúwa wa Jésù Kristì,
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún,
Àwọn Àpóstólì àti Ajé̩rìíkú ù Re̩,
Pétérù òun Pó̩ò̩lù,
Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Re̩:
fifun wa nípà ìtòye àti è̩bè̩ wó̩n,
pé nínú ohun gbogbo
kí á lè gbè wá níjà
nípasè̩ ìrànló̩wó̩ àbò Re̩.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín[red][b])[/b][/red]

Nítorí náà Olúwa, àwa ń gbàdúrà: 
fi ojú rere gba ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩; 
s̩e ètò gbogbo ò̩jó̩ ayé wa nínú àlàáfíà Rè̩, 
kí Ìwo̩ sì pàs̩e̩ ká gbà wá kúrò nínú ègbé ayérayé, 
ká sì kà wá kún agbo Àwọn tí Ìwo̩ ti yàn.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí Ìwo̩ sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Re̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní ò̩jó̩ tó s̩íwájú ò̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní ò̩wó̩ mímó̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní ò̩wó̩ mímó̩ Rè̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó gbé ife náà fún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ È̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩.  
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa."
},
new Communicantes
{
    Season = "Christmas",
    Comment = "Láti o̩dún Kérésìmesì títí di Sátidé tó tè̩lé e",
    Text = @"Ní ìdàpò̩ pè̩lú gbogbo Ìjọ ni àwa ń s̩e ayé̩yé òru [red][b]([/b][/red]ò̩jó̩[red][b])[/b][/red] mímó̩ jùlo̩ náà
nínú èyí tí Màríà Wúndíá aláìlábàwó̩n bí Olùgbàlà fún ayé yìí;
ní pàtàkì, à ń bu o̩lá fún ìrántí i 
Màríà láéláé Wúndíá ológo,
Ìyá O̩ló̩run àti Olúwa wa Jésù Kristì,
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún, 
Àwọn Àpóstólì àti Ajé̩rìíkú Rè̩ alábùkún-fún, 
Pétérù òun Pó̩ò̩lù, Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Re̩: 
àwa ń to̩ro̩ nípà ìtòyè àti è̩bè̩ wó̩n, 
pé nínú ohun gbogbo 
kí á lè gbèwáníjà nípasè̩ ìrànló̩wó̩ àbò Re̩.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
àwa ń bè̩bè̩:
kí e̩ran ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩ lè jé̩ àté̩wó̩gbà;
s̩e ètò gbogbo ò̩jó̩ ayé wa nínú àlàáfíà Rè̩,
gbà wá kúrò nínú ègbé ayérayé,
kí Ìwo̩ sì kà wá kún agbo Àwọn tí Ìwo̩ ti yàn.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí Ìwo̩ sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Re̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní ò̩jó̩ tó s̩íwájú ò̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní ò̩wó̩ mímó̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní ò̩wó̩ mímó̩ Rè̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó gbé ife náà fún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ È̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩.   
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa."
},
new Communicantes
{
    Season = "Epiphany",
    Comment = "Nígba Mísà o̩dún Ìfarahàn Olúwa",
    Text = @"Ní ìdàpò̩ pè̩lúu gbogbo Ìjọ ni àwa ń s̩e ayé̩yé ò̩jó̩ mímó̩ jùlo̩ náà
nínú èyí tí O̩mo̩ bíbí ì Rè̩ kan s̩os̩o,
nínú ògo Rè̩ ayéraye pè̩lú Ù Rè̩,
fi ara Rè̩ hàn nínú e̩ran ara tòótó̩ bíi tiwa;
ní pàtàkì, à ń bu o̩lá fún ìrántí i 
Màríà láéláé Wúndíá ológo,
Ìyá O̩ló̩run àti Olúwa wa Jésù Kristì
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún, 
Àwọn Àpóstólì àti Ajé̩rìíkú Rè̩ alábùkún-fún, 
Pétérù òun Pó̩ò̩lù, Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Rè̩: 
àwa ń to̩ro̩ nípà ìtòyè àti è̩bè̩ wó̩n, 
pé nínú ohun gbogbo 
ká lè gbèwáníjà nípasè̩ ìrànló̩wó̩ àbò Rè̩.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

Nítorí náà Olúwa, àwa ń gbàdúrà: 
fi ojú rere gba ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩; 
s̩e ètò gbogbo ò̩jó̩ ayé wa nínú àlàáfíà Rè̩, 
kí Ìwo̩ sì pàs̩e̩ ká gbà wá kúrò nínú ègbé ayérayé, 
ká sì kà wá kún agbo Àwọn tí Ìwo̩ ti yàn.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí Ìwo̩ sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Rè̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní ò̩jó̩ tó s̩íwájú ò̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní ò̩wó̩ mímó̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní ò̩wó̩ mímó̩ Rè̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó gbé ife náà fún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ È̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩.   
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa."
},
new Communicantes
{
    Season = "Maundy Thursday",
    Comment = "Nígba Mísà Oúnje̩-alé̩ Olúwa",
    Text = @"Bí a ti ń s̩e ayé̩yé ò̩jó̩ mímó̩ jùlo̩ náà 
nínú èyí tí a fa Jésù lé Àwọn apani ló̩wó̩ nítorí i wa 
àti ní ìdàpò̩s̩ò̩kan pè̩lú gbogbo Àwọn tí a ń fi àyé̩sí s̩e ìrántí wó̩n, 
ní pàtàkì Màríà Wúndíá ológo láéláé, Ìyá O̩ló̩run àti Olúwa wa Jésù Kristì,
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún, 
Àwọn Àpóstólì àti Ajé̩rìíkú Rè̩ alábùkún-fún, 
Pétérù òun Pó̩ò̩lù, Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Rè̩: 
àwa ń to̩ro̩ nípà ìtòyè àti è̩bè̩ wó̩n, 
pé nínú ohun gbogbo 
kí á lè gbèwáníjà nípasè̩ ìrànló̩wó̩ àbò Rè̩.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Nítorí náà Olúwa, àwa ń gbàdúrà: 
fi ojú rere gba ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩; 
s̩e ètò gbogbo ò̩jó̩ ayé wa nínú àlàáfíà Rè̩, 
kí Ìwo̩ sì pàs̩e̩ ká gbà wá kúrò nínú ègbé ayérayé, 
ká sì kà wá kún agbo Àwọn tí Ìwo̩ ti yàn.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí Ìwo̩ sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Rè̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní ò̩jó̩ tó s̩íwájú ò̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní ò̩wó̩ mímó̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní ò̩wó̩ mímó̩ Rè̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó gbé ife náà fún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ È̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩.    
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa."
},

new Communicantes
{
    Season = "Easter",
    Comment = "Láti àìsùn Àjíǹde títí dé Ò̩sè̩ kejì Àjíǹde",
    Text = @"Ní ìdàpò̩ pè̩lú gbogbo Ìjọ ni àwa ń s̩e ayé̩yé òru [red][b]([/b][/red]ò̩jó̩[red][b])[/b][/red] mímó̩ jùlo̩ náà
ti Àjíǹde Olúwa wa Jésù Kristì nínú ara;
ní pàtàkì, à ń bu o̩lá fún ìrántí i 
Màríà láéláé Wúndíá ológo,
Ìyá O̩ló̩run àti Olúwa,
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún, 
Àwọn Àpóstólì àti Ajé̩rìíkú Rè̩ alábùkún-fún, 
Pétérù òun Pó̩ò̩lù, Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Rè̩: 
àwa ń to̩ro̩ nípà ìtòyè àti è̩bè̩ wó̩n, 
pé nínú ohun gbogbo 
ká lè gbèwáníjà nípasè̩ ìrànló̩wó̩ àbò Rè̩.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

Nítorí náà Olúwa, àwa ń gbàdúrà, 
fi ojú rere gba ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩; 
tí a ń rú sí Ìwo̩ 
àti fún gbogbo Àwọn tó wù Ìwo̩ láti so̩ di àtúnbí 
nípa omi àti È̩mí Mímó̩, 
tí Ìwo̩ sì ń dári gbogbo è̩s̩e̩ wó̩n jì wó̩n;
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí Ìwo̩ sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Re̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní o̩jó̩ tó s̩íwájú o̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní o̩wó̩ mímó̩ o̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún O̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní o̩wó̩ mímó̩ o̩ Rè̩,
Ó fi o̩pé̩ fún O̩,
Ó súre,
Ó gbé ife náà fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩.   
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa."

},
new Communicantes
{
    Season = "Ascension",
    Comment = "Nígba Mísà Ìgòkè re ò̩run Olúwa",
    Text = @"Ní ìdàpò̩ pè̩lúu gbogbo Ìjọ ni àwa ń s̩e ayé̩yé ò̩jó̩ mímó̩ jùlo̩ náà
nínú èyí tí O̩mo̩ bíbí Ì Rè̩ kan s̩os̩o, Olúwa wa,
gbé àìlera wa gé̩gé̩ bí ènìyàn wò̩,
tí Ó sì gbé e ga sí apá ò̩tún Ùn Rè̩ nínú ògo;
ní pàtàkì, à ń bu o̩lá fún ìrántí i 
Màríà láéláé Wúndíá ológo,
Ìyá O̩ló̩run àti Olúwa wa Jésù Kristì̀,
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún, 
Àwọn Àpóstólì àti Ajé̩rìíkú Rè̩ alábùkún-fún, 
Pétérù òun Pó̩ò̩lù, Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Rè̩: 
àwa ń to̩ro̩ nípà ìtòyè àti è̩bè̩ wó̩n, 
pé nínú ohun gbogbo 
ká lè gbèwáníjà nípasè̩ ìrànló̩wó̩ àbò Rè̩.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

Nítorí náà Olúwa, àwa ń gbàdúrà: 
fi ojú rere gba ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩; 
s̩e ètò gbogbo ò̩jó̩ ayé wa nínú àlàáfíà Rè̩, 
kí Ìwo̩ sì pàs̩e̩ ká gbà wá kúrò nínú ègbé ayérayé, 
ká sì kà wá kún agbo Àwọn tí Ìwo̩ ti yàn.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí Ìwo̩ sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Rè̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní ò̩jó̩ tó s̩íwájú ò̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní ò̩wó̩ mímó̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní ò̩wó̩ mímó̩ Rè̩,
Ó fi o̩pé̩ fún Ìwo̩,
Ó súre,
Ó gbé ife náà fún Àwọn Ò̩mo̩-È̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ È̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]


Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩.  
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa.
"
},

new Communicantes
{
    Season = "Pentecost",
    Comment = "Nígba Mísà Ìsò̩kalè̩ È̩mi-Mímó̩",
    Text = @"Ní ìdàpò̩ pè̩lúu gbogbo Ìjọ ni àwa ń s̩e ayé̩yé ò̩jó̩ mímó̩ jùlo̩ náà
ti Pé̩ntíkó̩stì
tí È̩mí Mímó̩ farahàn Àwọn Àpóstólì bí ahó̩n iná;
ní pàtàkì, à ń bu o̩lá fún ìrántí
Màríà láéláé Wúndíá ológo,
Ìyá O̩ló̩run àti Olúwa wa Jésù Kristì̀,
àti Jósé̩fù o̩ko̩ Rè̩ alábùkún-fún, 
Àwọn Àpóstólì àti Ajé̩rìíkú Rè̩ alábùkún-fún, 
Pétérù òun Pó̩ò̩lù, Áńdérù,
[red][b]([/b][/red]Jákó̩bù, Jòhánu, Tó̩másì, 
Jákó̩bù, Fílípì, Batolómíù, 
Mátíù, Símónì àti Júùdù: 
Línù, Kílétù, Kílé̩mé̩ntì, 
Sístù, Kò̩nélíu, Sípríanì, 
Ló̩ré̩nsì, Krísógónù, Jòhánù àti Páúlu, 
Kó̩smasì àti Dámíánì[red][b])[/b][/red]
àti gbogbo Àwọn Ènìyàn Mímó̩ ò̩ Rè̩: 
àwa ń to̩ro̩ nípà ìtòyè àti è̩bè̩ wó̩n, 
pé nínú ohun gbogbo 
ká lè gbèwáníjà nípasè̩ ìrànló̩wó̩ àbò Rè̩.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

Nítorí náà Olúwa, àwa ń gbàdúrà: 
fi ojú rere gba ìrúbo̩ ìsin ti gbogbo ìdílé Rè̩; 
s̩e ètò gbogbo ò̩jó̩ ayé wa nínú àlàáfíà Rè̩, 
kí Ìwo̩ sì pàs̩e̩ ká gbà wá kúrò nínú ègbé ayérayé, 
ká sì kà wá kún agbo Àwọn tí Ìwo̩ ti yàn.
[red][b]([/b][/red]Nípasè̩ Krístì Olúwa wa. Àmín.[red][b])[/b][/red]

O̩ló̩run, à ń bè̩bè̩,
bojúwò ìrúbo̩ yìí,
kà á ye̩
kí O sì bùkún fún un ní gbogbo ò̩nà,
s̩e é ní mímó̩ àti àté̩wó̩gbà,
kí ó ba lè di Ara àti È̩jè̩ O̩mo̩ ò̩ Re̩ àyànfé̩,
Olúwa wa Jésù Kristì fún wa.

Ní o̩jó̩ tó s̩íwájú o̩jó̩ tí Ó jìyà,
Ó mú búré̩dì ní o̩wó̩ mímó̩ o̩ Rè̩,
bí Ó ti gbé ojú sókè ò̩run,
sí Ìwo̩ O̩ló̩run Baba Rè̩ alágbára jùlo̩,
Ó fi o̩pé̩ fún O̩,
Ó súre,
Ó bu búré̩dì náà
Ó sì fifún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife oníyebíye yìí ní o̩wó̩ mímó̩ o̩ Rè̩,
Ó fi o̩pé̩ fún O̩,
Ó súre,
Ó gbé ife náà fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]



Olúwa,
nínú ìrúbo̩ yìí
àwa ìráns̩é̩ è̩ Re̩ àti ènìyàn Re̩ mímó̩
ń s̩e ìrántí ìjìyà alábùkún-fún,
Àjíǹde kúrò ní ipò òkú,
àti Ìgòké re ò̩run ológo ti Kristì O̩mo̩ ò̩ Re̩, Olúwa wa:
à ń rú e̩bo̩ o̩pé̩ yìí fún o̩láńlá à Re̩
láti inú àwo̩n è̩bùn tí O fún wa,
e̩ran e̩bo̩ pípé,
e̩ran e̩bo̩ mímó̩,
àti e̩ran e̩bo̩ tí kò lábàwó̩n yìí,
èyí tí i s̩e Búré̩dì mímó̩ ti ìyè ayérayé
àti Ife ìgbàlà àìnípè̩kun.

Jé̩ kí ó wù Ó̩ láti bojúwo àwo̩n o̩re̩ wò̩nyí,
pè̩lú ojú è̩rò̩ àti àánú:
kí O sì gbà wó̩n
gé̩gé̩ bí O ti fi inú dídùn gba è̩bùn o̩mo̩-ò̩dò̩ Re̩
Ábé̩lì olódodo,
ìrúbo̩ Ábráhámù Baba wa nínú ìgbàgbó̩,
àti e̩bo̩ mímó̩ aláìlábàwó̩n tí Mé̩lkísé̩dé̩kì olórí àlùfáà Re̩ rú sí O̩.
O̩ló̩run Olódùmarè,
à ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩
jò̩wó̩ pàs̩e̩ kí àwo̩n ángé̩lì mímó̩ ò̩ Re̩
fi o̩wó̩ o̩ wo̩n gbé àwo̩n o̩re̩ wò̩nyí lo̩ sóri pe̩pe̩ è̩ Re̩ mímó̩
níwájú ìté̩ o̩láńlá à Re̩ ló̩run;
kí ó lè jé̩ pé gbogbo àwa tí a tipasè̩ ìbápín ní orí i pe̩pe̩ yìí
gba Ara àti È̩jè̩ mímó̩ jùlo̩ ti O̩mo̩ ò̩ Re̩
lè kún fún gbogbo oore-ò̩fé̩
àti ìbùkún àtò̩runwá à Re̩. 
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

[red][i]Ìrántí àwo̩n olóògbé[/i][/red]

Olúwa, rántí àwo̩n o̩mo̩-ò̩dò̩ Re̩ ló̩kùnrin àti lóbìnrin,
nípàtàkì [red][b]N.[/b][/red] àti [red][b]N.[/b][/red],
tí wó̩n ti s̩íwájú wa lo̩ pè̩lú àmì ìgbàgbó̩
tí wó̩n ń sùn ní àlàáfíà.
Olúwa, àwá ń bè̩ Ó̩
fún àwo̩n wò̩nyí,
àti gbogbo àwo̩n tí wó̩n ń sinmi nínú Krístì
ní ibùgbé ìtura,
ibùgbé ìmó̩lè̩
àti ibùgbé àlàáfíà.
[red][b]([/b][/red]Nípasè̩ Kristì Olúwa wa. Àmín.[red][b])[/b][/red]

Olúwa,
fún àwa ìráns̩é̩ è̩ Re̩ e̩lé̩s̩è̩ pè̩lú,
ti a ní ìrètí nínú ò̩pò̩ àánú ùn Re̩,
jò̩wó̩ fún wa ní ìpín àti àjo̩s̩epò̩
pè̩lú àwo̩n Àpóstólì àti àwo̩n Ajé̩rìíkú mímó̩ ò̩ Re̩,
pè̩lu Jòhánù oníbatisí,
Stéfánù, Màtáyà, Bánábà,
[red][b]([/b][/red]Ìgnátíù, Ale̩ksándà, Màsè̩línù,
Pétérù, Fè̩lísítì, Pè̩pé̩túà, Ágátà, Lúsì, Ágné̩sì,
Sìsílíà, Anastásíà[red][b])[/b][/red]
àti gbogbo àwo̩n ènìyàn mímó̩ ò̩ Re̩.
Bí ó tilè̩ jé̩ pé a kò ye̩ fún un nípa is̩é̩ e̩ wa
àwa ń bè̩bè̩ nínú ò̩pò̩ àánú ùn Re̩,
kí O kà wá mó̩ iye wo̩n
nípasè̩ Kristì Olúwa wa.

Nípasè̩ e̩ni tí O ń s̩e ohun rere wò̩nyí nígba gbogbo,
Ìwo̩ O̩ló̩run,
O yà wó̩n sí mímó̩,
O kún wo̩n fún ìyè,
O bùkún fún wo̩n,
O sì fi wó̩n jíǹkí wa."
},
            }
        },
        new EucharisticPrayer
        {
            Number = "II",
            Title = "Àdúrà Yukaristí kejì",
            Season = "Àdúrà Yukaristí II",
            Comment = null,
            Text = @"Nítòótó̩, mímó̩ ni Ìwo̩, Olúwa,
orísun gbogbo ohun mímó̩.
Àwá ń bè̩ Ó̩,
kí O so̩ àwo̩n o̩re̩ wò̩nyí di mímó̩
nípa rírán ìmísí È̩míì Re̩ sóríi wo̩n,
bí ìrì tí ń sè̩,
kí wó̩n lè di Ara [red][b]✠[/b][/red] àti È̩jè̩ Olúwa wa Jésù Kristì fún wa. 

Ní ìgbà tí Ó jò̩wó̩ ara Rè̩ fún ìjìya ikú,
Ó mú búré̩dì,
Ó fi o̩pé̩ fún O̩,
Ó bù ú,
Ó sì fifún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà, nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife,
Ó sì dúpé̩ lé̩è̩kan síi
Ó gbé e fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé: 

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]



Bí a ti ń s̩e ìrántí ikú àti àjíǹde Rè̩,
àwa ń fi Búré̩dì ìyè
àti Ife ìgbàlà yìí
to̩re̩ fún O̩ Baba wa ò̩run,
a ń dúpé̩ pé
O ti kà wá ye̩ láti dúró níwájú ù Re̩
láti sìn Ó̩.

A ń fi ìrè̩lè̩ bè̩bè̩
pé kí È̩mí mímó̩ lè s̩e gbogbo wa ní ò̩kan,
àwa tí a ń pín nínú Ara àti È̩je̩ Krístì.

Olúwa, rántí Ìjo̩ ò̩ Re̩ tó tàn ká gbogbo ayé,
kí O sì mú u dé è̩kúnré̩́ré̩ ìfé̩ni,
pè̩lú Pápà a wa [red][b]N.[/b][/red] àti Bís̩ó̩bù u wa [red][b]N.[/b][/red] àti gbogbo àwo̩n àlùfáà.

[red]– – – – – – – – – –[/red]
    [red][i]Nínú Mísà fún àwo̩n òkú[/i][/red]

Rántí o̩mo̩-ò̩dò̩ Re̩  [red][b]N.[/b][/red]. 
tí Ìwo̩ ti pè (lónìí) kúrò ní ayé yìí sí ò̩dò̩ Re̩.
Fifún wa pé bí ó ti jé̩ ò̩kan pè̩lú o̩mo̩ ò̩ Re̩ nínú ikú bíi tirè̩,
kí ó lè jé̩ ò̩kan pè̩lúu Rè̩ nínú àjíǹde Rè̩. 

[red]– – – – – – – – – –[/red]

Rántí àwo̩n arákùnrin àti arábìnrin wa pè̩lú
tí wó̩n ti sùn nínú ìrètí àjíǹde
àti gbogbo àwo̩n tí wó̩n ti kú nínú àánú ùn Re̩,
gbà wó̩n sínú ìmó̩lè̩ ojúù Re̩.

S̩àánú fún gbogbo wa, a ń bè̩ Ó̩,
pé pè̩lúu Màríà Wúndíá alábùkún-fún, Ìyá O̩ló̩run,
pè̩lúu Jósé̩fù alábùkún-fún o̩ko̩ rè̩,
pè̩lú àwo̩n Àpóstólì alábùkún-fún
àti gbogbo àwo̩n ènìyàn mímó̩
tí wó̩n ti s̩e ohun tó té̩ O̩ ló̩rùn láti ìs̩è̩dálè̩ ayé wá,
jé̩ ká lè ye̩ láti jé̩ ajùmò̩jogún ìyè àìnípè̩kun,
kí á lè máa yìn Ó̩, ká sì máa fi ògo fún O̩,
nípasè̩ Jésù Krístì O̩mo̩ ò̩ Re̩.

"
        },
        new EucharisticPrayer
        {
            Number = "III",
            Title = "Àdúra Yukaristí ke̩ta",
            Season = "Àdúrà Yukaristí III",
            Comment = "Àlùfáà nìkan yóò gbàdúrà báyìí pé:",
            Text = @"Nítòótó̩, mímó̩ ni Ìwo̩ Olúwa,
gbogbo ohun tí O dá ń yìn Ó̩ lógo bí ó ti ye̩,
nítorí pé nípasè̩ O̩mo̩ ò̩ Re̩ Olúwa wa Jésù Krístì,
nípa agbára àti is̩é̩ e̩ ti È̩mí Mímó̩,
Ìwo̩ ń fún ohun gbogbo ní ìyè,
O sì ń so̩ wó̩n di mímó̩;
Ìwo̩ kò dé̩kun láti máa kó àwo̩n ènìyàn jo̩ fún ara à Re̩
tí yóò fi jé̩ pé, láti lílà oòrùn títí dé wíwò̩ o̩ rè̩,
a ó lè máa rú e̩bo̩ pípé fún ògo orúko̩ ò̩ Re̩. 

Nítorí náà, Olúwa,
àwa ń fi ìrè̩lè̩ bè̩bè̩ ló̩dò̩ Re̩,
fi ojú rere so̩ àwo̩n o̩re̩ wò̩nyí
tí a mú wá só̩dò̩ Re̩ di mímó̩, nípasè̩ È̩mí kan náà
kí wó̩n lè di Ara [red]✠[/red] àti È̩je̩ ti O̩mo̩ ò̩ Re̩ Olúwa wa Jésù Krístì,
nípa às̩e̩ E̩ni tí a ń s̩e àwo̩n ohun-ìjìnlè̩ yìí. 

Ní alé̩ náà tí a dalè̩ e̩ Rè̩,
Jésù fúnrarè̩ mú búré̩dì,
Ó fi o̩pé̩ fún O̩,
Ó súre
Ó bù ú,
Ó sì fifún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé: 

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnjé̩ alé̩ tán,
Ó gbé ife,
Ó fi o̩pé̩ fún O̩,
Ó súre
Ó sì gbé e fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé: 

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà Olúwa,
a ń s̩e ìrántí ìjìyà ìràpadà ti O̩mo̩ ò̩ Re̩,
Àjíǹde Rè̩ àgbàyanu
àti Ìgòkè re ò̩run Rè̩,
bí a sì ti ń fojúsó̩nà de ìpadàbo̩ Rè̩,
a ń fi ìdúpé̩ rú e̩bo̩ mímó̩ alààyè yìí sí O̩.
A ń bè̩ Ó̩, bojú wo e̩bo̩ ti Ìjo̩ ò̩ Re̩,
kí O sì fi ojú rere wo e̩ran e̩bo̩ náà,
tí Ó wù ó̩ láti tipasè̩ ikú u Rè̩ parí ìjà wa pè̩lú ù Re̩,
jé̩ kí àwa tí a ń fi Ara àti È̩jè̩ O̩mo̩ ò̩ Re̩ bó̩
tí a sì kún fún È̩mí Mímó̩ o̩ Rè̩,
lè di ara kan àti è̩mí kan nínú Krístì.

Kí Ó so̩ wá di o̩re̩ àìlópin fún O̩,
kí á ba lè ye̩ láti jé̩ ajùmò̩jogún pè̩lú àwo̩n tí O ti yàn,
ní pàtàkì pè̩lúu Màríà Wúndíá alábùkún-fún jùlo̩, Ìya O̩ló̩run,
pè̩lu Jósé̩fù alábùkún-fún o̩ko̩ rè̩
àti àwo̩n Àpóstólì Re̩ alábùkún-fún
àti àwo̩n Ajé̩rìíkú ù Re̩ ológo,
[red][b]([/b][/red] [red][i]pè̩lú[/i][/red] [red][b]N.[/b][/red][red][i]: dárúko̩ ènìyàn mímó̩ tàbì orúko̩ aláàbò Ilé- O̩ló̩run[/i][/red][red][b])[/b][/red] 
àti pè̩lú gbogbo àwo̩n ènìyàn mímó̩,
nínú àwo̩n e̩ni tí a ní ìgbé̩kè̩lé̩ pé
pè̩lú àdúrà a wo̩n níwájú ù Re̩ nígbà gbogbo,
a ní ìdánilójú láti rí ìrànló̩wó̩ ò̩ Re̩.

Olúwa, a bè̩ Ó̩, jé̩ kí e̩bo̩ ìlàja wa yìí
mú àlàáfíà àti ìgbàlà gbogbo ayé pò̩ sí i.
Jé̩ kí Ó wù Ó̩ láti fi e̩sè̩ Ìjo̩ ò̩ Re̩
tó ń rìnrìnàjò ní ayé múlè̩ nínú ìgbàgbó̩ àti ìfé̩ni
pè̩lú o̩mo̩-ò̩dò̩ Re̩ Pápà a wa N. àti Bís̩ó̩ò̩bù u wa N. 
agbo àwo̩n Bís̩ó̩ò̩bù,
gbogbo àwo̩n àlùfáà,
àti gbogbo àwo̩n ènìyàn tí O ti jèrè fún ara à Re̩.

Fi ojú rere gbó̩ è̩bè̩ ìdílé yìí,
tí Ìwo̩ ti pè wá sí iwájú ù Re̩.
Baba aláàánú, nínú ò̩pò̩ àánú ùn Re̩,
kó gbogbo àwo̩n o̩mo̩ ò̩ Re̩ jo̩ só̩dò̩ Re̩
lati gbogbo ibi tí wó̩n tàn káàkiri dé.

Nínú àánú ùn Re̩
gba gbogbo àwo̩n arákùnrin àti arábìnrin wa olóògbé
àti gbogbo àwo̩n tí wó̩n ti fi ayé yìí sílè̩ ní ìré̩pò̩ pè̩lú ù Re̩
sínú ìjo̩ba à Re̩.
Níbi tí a ti jo̩ ní ìretí láti je̩ ìgbádùn ògo ò Re̩ títí láé,
nípasè̩ Jésù Krístì Olúwa wa,
nípasè̩ E̩ni tí Ìwo̩ fi ohun rere gbogbo jíǹkí ayé.

[red]– – – – – – – – – –[/red]
    [red][i]Nínú Mísà fún àwo̩n òkú[/i][/red]

Rántí o̩mo̩-ò̩dò̩ Re̩ [red][b]N.[/b][/red]
tí Ìwo̩ ti pè (lónìí) kúrò ní ayé yìí lo̩ sí ò̩dò̩ Re̩.
Bí ó ti jé̩ ò̩kan pè̩lú O̩mo̩ ò̩ Re̩ nínú ikú bíi tirè̩,
jé̩ kí ó lè jé̩ ò̩kan pè̩lúu Rè̩ nínú àjíǹde Rè̩
nígbà tí yóò jí àwo̩n tí wó̩n ti kú nínu ara dìde láti inú ilè̩,
tí yóò sì yí ara ìdíbàjé̩ wa padà láti dàbí ara ológo bíi tirè̩.
Nínú àánú ùn Re̩
gba gbogbo àwo̩n arákùnrin àti arábìnrin wa olóògbé
àti gbogbo àwo̩n tí wó̩n ti fi ayé yìí sílè̩ ní ìré̩pò̩ pè̩lú ù Re̩
sínú ìjo̩ba à Re̩.
Níbi tí a ti jo̩ ní ìretí láti je̩ ìgbádùn ògo ò Re̩ títí láé,
nígbà náà ni Ìwo̩ yóò nu gbogbo omijé ojú u wa nù.
Nítorí a óò rí Ìwo̩ O̩ló̩run wa bí O s̩e rí,
a ó dàbíì Re̩ títí láé,
a ó sì máa yìn Ó̩ láìdé̩kun,
nípasè̩ Jésù Krístì Olúwa wa,
nípasè̩ E̩ni tí Ìwo̩ fi ohun rere gbogbo jíǹkí ayé.

[red]– – – – – – – – – –[/red]
"
        },
 new EucharisticPrayer
        {
            Number = "IV",
            Title = "Àdúra Yukaristí ke̩rin",
            Season = "Àdúrà Yukaristí IV",
            Comment = "Àlùfáà nìkan yóò gbàdúrà báyìí pé:",
            Text = @"Baba Mímó̩, àwa ń yìn Ó̩,
nítorí pé O tóbi O sì ti s̩e ètò gbogbo is̩é̩ è̩ Re̩
pè̩lú o̩gbó̩n àti ìfé̩.

Ìwo̩ ti dá ènìyàn ní àwòrán ara à Re̩,
O sì fi ìs̩àkóso gbogbo ayé sí ìkáwó̩ o̩ rè̩,
pé ní sínsin Ìwo̩ E̩lé̩dàá nìkan s̩os̩o,
kí òun lè jo̩ba lóríi gbogbo è̩dá.
Àti bí ó ti lè̩ jé̩ pé nípa àìgbó̩ràn
ó pàdánù ìré̩pò̩ pè̩lúù Re̩,
Ìwo̩ kò kò̩ ó̩ sílè̩ sí abè̩ agbára ikú.
Ìwo̩ wá pè̩lú àánú láti ran gbogbo è̩dá ló̩wó̩,
kí àwo̩n tí ń wá O̩ baà lè rí O̩.
Ní ò̩pò̩ ìgbà ni O bá wo̩n dá májè̩mu,
O sì kó̩ wo̩n, nípasè̩ àwo̩n wòlíì,
láti ní ìrètí fún ìgbàlà.

Baba Mímó̩
Ìwo̩ fé̩ràn ayé tó bé̩è̩ gé̩,
nígbá tí àkókò tó
tí Ìwo̩ fi rán O̩mo̩-bíbí ì Re̩ kan s̩os̩o sí wa bí Olùgbàlà.
E̩ni tí a so̩ di ènìyàn nípa agbára È̩mí Mímó̩,
tí a sì bí láti inú un Màríà Wúndíá,
Ó pín nínú gbogbo ipo ènìyan wa,
àfi ní ti è̩s̩è̩.
Ó wàásù Ìyìnrere ìgbàlà fún àwo̩n tálákà,
ìdáǹdè fún àwo̩n tó wà nínú ìgbèkùn
àti ayò̩ fún àwo̩n oníbànújé̩ o̩kàn.

Làti mú ètò Re̩ s̩e̩,
Ó jò̩wó̩ ara Rè̩ fún ikú.
Nígbà tí Ó sì jíǹde
Ó pa ikú run,
Ó sì dá ìyè padà. 

Àti ká má wà fún ara wa nìkan mó̩
bíkòs̩e fún Òun tí Ó kú tí Ó sì jíǹde fún wa,
O rán È̩mí Mímó̩ láti ò̩dò̩ Re̩, Baba,
gé̩gé̩ bí è̩bùn àkó̩kó̩ fún àwo̩n tó gbàgbó̩,
láti s̩e às̩epé is̩é̩ è̩ Re̩ ní ayé
àti láti parí ìso̩dimímó̩ ohun gbogbo.

Nítorí náà Olúwa,
àwa ń bè̩ Ó̩,
jé̩ kí È̩mí Mímó̩ kan náà
fi ojú rere ya àwo̩n o̩re̩ yìí sí mímó̩,
kí wó̩n lè di Ara 
[red]✠[/red] àti È̩jè̩ Olúwa wa Jésù Krístì,
bí a ti ń s̩e ohun-ìjìnlè̩ ńlá yìí,
èyí tí Òun funrarè̩ fi sílè̩ fún wa gé̩gé̩ bíi májè̩mu ayérayé.

Nígbà tí wákàtí náà dé fún un
láti gba ògo láti ò̩dò̩ Re̩, Baba mímó̩,
bí Ó ti fé̩ràn àwo̩n tirè̩ tí wó̩n wà nínú ayé,
Ó fé̩ràn wo̩n títí dé òpin:
bí wó̩n ti ń je̩ oúnje̩-alé̩,
Ó mú búré̩dì,
Ó súre,
Ó bù ú,
Ó sì fi í fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
Ó gbé ife tó kún fún wáìnì láti inú èso àjàrà
Ó dúpé̩,
Ó gbé ife náà fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé: 

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Olúwa,
bi a ti ń s̩e ìrántí ìràpadà wa nísinsìnyí
a ń rántí ikú Krístì,
àti ìsò̩kalè̩ e̩ Rè̩ lo̩ sí ipò òkú,
a ń kéde Àjíǹde Rè̩,
àti Ìgòkè re ò̩run Rè̩ sí o̩wó̩ ò̩tún ùn Re̩;
bí a sì ti ń fojúsó̩nà fún wíwá a Rè̩ nínú ògo,
a ń fi Ara àti È̩je̩ Rè̩ rúbo̩ sí O̩,
e̩bo̩ tó jé̩ àté̩wó̩gbà fún O̩,
tí ó sì ń mú ìgbàlà wá fún gbogbo ayé.

Olúwa, bojúwo e̩bo̩ yìí,
tí Ìwo̩ fúnràre̩ ti pèsè fún Ìjo̩ ò̩ Re̩,
nínú ìfé̩ olóore è Re̩,
fifún gbogbo àwo̩n wo̩nnì tí yóò jé̩ alábàápín nínú Búré̩dì kan
àti Ife kan yìí,
pé bí È̩mí Mímó̩ s̩e kó wo̩n jo̩ pò̩ gé̩gé̩ bí ara kan
kí wó̩n lè di e̩bo̩ alààye nínú Kristì
fún ìyìn ògo ò Re̩.

Nísinsìnyí Olúwa,
rántí gbogbo àwo̩n wo̩nnì tí à ń rú e̩bo̩ yìí sí O̩ fún,
ní pàtàkì o̩mo̩-ò̩dò̩ Re̩ Pápà a wa 
 [red][b]N.[/b][/red]Bís̩ó̩bù u wa, 
[red][b]N.[/b][/red] àti agbo àwo̩n bís̩ó̩ò̩bù,
gbogbo àwo̩n àlùfáà,
àwo̩n tí wó̩n ń kópa nínú ìsìn yìí,
àwo̩n tó péjo̩ pò̩ níhìn níwájú ù Re̩,
gbogbo àwo̩n ènìyan Re̩,
àti gbogbo àwo̩n wo̩nnì tí wó̩n ń fi o̩kàn tòótó̩ wá O̩.

Bákan náà rántí àwo̩n arákùnrin àti arábìnrin wa
tí wó̩n ti s̩e aláìsí nínú àlàáfíà Kristì
àti gbogbo àwo̩n òkú
tí ìgbàgbó̩ wo̩n jé̩ mímò̩ fún Ìwo̩ nìkan.

Baba aláàánú,
fifún gbogbo àwa o̩mo̩ ò̩ Re̩
pé ká lè ye̩ látí wo̩ inú ìjogún ò̩run
pè̩lúu Màríà Wúndíá alábùkún-fun, Ìya O̩ló̩run,
pè̩lú Jósé̩fù alábùkún-fún o̩ko̩ rè̩,
pè̩lú àwo̩n Àpóstólì àti àwo̩n ènìyàn mímó̩ nínú ìjo̩ba à Re̩,
níbè̩, pè̩lúu gbogbo è̩dá;
pé bí a ti dá wa nídè kúrò nínú ìdíbàjé̩ è̩s̩è̩ àti ikú,
ká lè máa yìn Ó̩ lógo nipasè̩ Kristì Olúwa wa,
nípasè̩ E̩ni tí O fi gbogbo ohun tó dára jíǹkí ayé.

"
        },
 new EucharisticPrayer
        {
            Number = "V",
            Title = "Mísà Ìlàjà kìnní",
            Season = "Àdúra Yukaristí ti Ìlàjà I",
            Comment = "A lè lo àwo̩n Àdúra Yukaristí ti Ìlàjà fún àwo̩n Mísà wò̩nyí: Àlàáfíà àti Ìdájó̩ Òdodo, Ìlàjà, Nígbà ogun tàbí rògbòdìyàn, Ìdáríjì-è̩s̩è̩, Ìto̩re̩-àánú, Àgbélébùú Mímó̩, Yukaristí Mímó̩ Jùlo̩, È̩jè̩ oníyebíye Mímó̩ jùlo̩ ti Jésu àti Mísà nígbà Ààwè̩.",
            Text = @" [red][i]Àlùfáà nìkan yóò gbàdúrà báyìí pé:[/i][/red]

Nítòótó̩ mímó̩ ni Ìwo̩ Olúwa
láti ìpilè̩s̩è̩ ayé ni Ìwo̩ kò ti dé̩kun láti máa s̩is̩é̩
pé bí Ìwo̩ fúnraàre̩ ti jé̩ mímó̩
kí ìran ènìyàn náà lè jé̩ mímó̩.

A ń bè̩bè̩, kí O bojúwo àwo̩n o̩re̩ àwa ènìyàn Re̩
kí O sì da agbára È̩mí Mímó̩ ò̩ Re̩ lé wo̩n lórí
kí wó̩n baà lè di [red]✠[/red] Ara àti È̩je̩ ti O̩mo̩ ò̩ Re̩ àyànfé̩, Jésù Kristi,
nípasè̩ E̩ni tí àwa náà ti di o̩mo̩ ò̩ Re̩.

Ni tòótó̩, bí ó tilè̩ jé̩ pé a ti fi ìgbà kan kùnà rí
tí a kò sì lè súnmó̩ O̩,
Ìwo̩ fé̩ràn wa pè̩lú ìfé̩ tó ga jùlo̩:
O̩mo̩ ò̩ Re̩, E̩nìkan s̩os̩o tí Ó jé̩ olódodo, jò̩wó̩ ara Rè̩ fún iku,
kò sì kò̩ láti gba ikú lórí àgbálébùú nítorí i wa.

Kí Ó tó na apá a Rè̩ láàárín ò̩run àti ayé
gé̩gé̩ bí àmì májè̩mú tí kò leè pare̩ láéláé,
Ó fé̩ láti s̩e o̩dún ìréko̩já pè̩lú àwo̩n o̩mo̩-è̩yin Rè̩.

Bí Ó ti ń je̩un pè̩lúu wo̩n,
Ó mú búré̩dì,
bí Ó sì ti ń fi o̩pé̩ fún O̩
Ó bùkún fún un,
Ó bùú Ó sì fifún wo̩n, bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
bí Ó ti mò̩ pé Òun ti fé̩ s̩e ìlàjà ohun gbogbo nínú ara Rè̩
nípa títa È̩je̩ Rè̩ sílè̩ lórí àgbélébùú
Ó gbé ife tó kún fún wáìnì láti inú èso àjàrà
lé̩è̩kan síi ó fi o̩pé̩ fún O̩,
Ó sì gbé e fún àwo̩n o̩mo̩-è̩yin Rè̩, bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.

[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà, bí a ti ń s̩e ayé̩ye̩ ìrántí Jésù Kristì O̩mo̩ ò̩ Re̩
E̩ni tí Í s̩e ìréko̩já a wa àti àlàáfíà wa,
àwa ń s̩e ìrántí ikú u Rè̩ àti Àjíǹde kúrò nínú òkú;
bí a sì s̩e ń retíi wíwá a Rè̩,
a ń rú e̩bo̩ yìí sí O̩,
Ìwo̩ O̩ló̩run olótìító̩ àti aláàánú,
e̩bo̩ èyí tó ń s̩e ìlàjà láàárín ìran ènìyàn àti Ìwo̩ E̩lé̩dàá wa.

Baba aláàánú jùlo̩, ni inú rere è Re̩,
bojúwo àwo̩n tí O dàpò̩ s̩ò̩kan pè̩lú ù Re̩ nípa e̩bo̩ Krístì,
bí wó̩n s̩e ń jé̩ alábàápín nínú Búré̩dì àti Ife kan náà
jé̩ kí agbára È̩mí Mímó̩ so̩ wó̩n di o̩kàn nínú Kristi,
E̩ni tí O ń wo gbogbo ìyapa sàn.

Jé̩ kí ó wù Ó̩ láti pa wá mó̩ nínú ìré̩pò̩ o̩kàn àti ara
pè̩lúu  [red][b]N.[/b][/red] Pápà a wa àti   
[red][b]N.[/b][/red] Bís̩ó̩ò̩bù u wa.
Ràn wá ló̩wó̩ láti lè jo̩ dúró de wíwá ìjo̩ba à Re̩
títí di wákàtí náà, tí a óò dúró ní iwájú ù Re̩,
ènìyàn mímó̩ láàárín àwo̩n ènìyàn mímó̩
ní àgbàlá ò̩run,
pè̩lúu Màríà Wúndíá alábùkún-fún Ìyá O̩ló̩run,
pè̩lú Jósé̩fù alábùkún-fún o̩ko̩ rè̩,
pè̩lú àwo̩n Àpóstólì alábùkún-fún,
gbogbo àwo̩n ènìyàn mímó̩,
ati pè̩lú àwo̩n ará a wa olóògbé
tí a ń fi ìrè̩lè̩ to̩ro̩ àánú fún ló̩dò̩ Re̩.

Nítorí náà, nísinsìnyí ti a ti dá wa nídè kúrò nínú o̩gbé̩ ìdíbàjé̩
tí a sì ti so̩ wá di è̩dá tuntun lé̩kùnńré̩ré̩
a óò wá fi tayò̩tayò̩ ko̩ orin is̩é̩ oore-ò̩fé̩ e̩ ti Krístì Re̩
E̩ni tí Ó wà títí ayérayé."
        },
  new EucharisticPrayer
        {
            Number = "VI",
            Title = "Mísà ìlàjà kejì",
            Season = "Àdúra Yukaristí ti Ìlàjà II",
            Comment = "A lè lo àwo̩n Àdúra Yukaristí ti Ìlàjà fún àw̩on Mísà wò̩nyí: Àlàáfíà àti Ìdájó̩ Òdodo, Ìlàjà, Nígbà ogun tàbí rògbòdìyàn, Ìdáríjì-è̩s̩è̩, Ìto̩re̩-àánú, Àgbélébùú Mímó̩, Yukaristí Mímó̩ Jùlo̩, È̩jè̩ oníyebíye Mímó̩ jùlo̩ ti Jésu àti Mísà nígbà Ààwè̩.",
            Text = @"    [red][i]Àlùfáà nìkan yóò gbàdúrà báyìí pé:[/i][/red]

Nítorí náà, Baba Olódùmarè
a ń fi ìbùkún fún O̩ nípasè̩ Jésù Kristì O̩mo̩ ò̩ Re̩
E̩ni tí Ó wá ní orúko̩ ò̩ Re̩.
Òun funrarè̩ ni Ò̩rò̩ ti ó ń mú ìgbàlà wá fún àwo̩n ènìyàn,
O̩wó̩ tí O nà sí àwo̩n e̩lé̩s̩è̩,
Ò̩nà tí O gbà fún wa ni àlàáfíà Re̩.
Olúwa, nígbà tí àwa fúnrawa ti yípadà kúrò ló̩dò̩ Re̩
nítorí àwo̩n è̩s̩e̩ wa,
Ìwo̩ s̩e ìlàjà, O sì mú wa padà só̩dò̩ Re̩,
pé, nígbà tí a bá padà só̩dò̩ Re̩ tán,
kí á lè fé̩ràn ara wa nípasè̩ O̩mo̩ ò̩ Re̩
E̩ni tí Ó jé̩ pé nítorí i tiwa ni O s̩e fi lé agbára ikú ló̩wó̩.

Nítorí náà, bí a ti ń s̩e ayé̩ye̩ ìlàjà tí Kristí mú wá fún wa,
àwa ń bè̩ Ó̩,
kí O ya àwo̩n o̩re̩ wa yìí sí mímó̩ nípa ìmísí È̩míì Re̩
kí wó̩n lè di [red]✠[/red] Ara àti È̩jè̩ O̩mo̩ ò̩ Re̩
nípa às̩e̩ E̩ni tí a ń s̩e àwo̩n ohun-ìjìnlè̩ mímó̩ yìí.

Nígbà tí Ó ti múra tán láti jò̩wó̩ È̩míi Rè̩ fún ìgbàla wa,
bí wó̩n ti fé̩ máa je̩ oúnje̩-alé̩
Ó mú búré̩dì ní o̩wó̩ o̩ Rè̩
bí Ó ti ń fi o̩pé̩ fún O̩
Ó bùkún fún un,
Ó bù ú,
Ó sì fifún àwo̩n O̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
ní alé̩ o̩jó̩ náà
Ó gbé ife ìbùkún ní o̩wó̩ o̩ Rè̩,
bí Ó ti ń jé̩wó̩ àànú un Re̩
Ó gbé ife náà fún àwo̩n o̩mo̩-è̩yin Rè̩,
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.


[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà, bí a ti ń s̩e aye̩ye̩ ìrántí ikú àti àjíǹde O̩mo̩ ò̩ Re̩,
E̩ni tí Ó fi ìlérí ìfé̩ e̩ Rè̩ yìí sílè̩ fún wa
àwa ń fi ohun tí Ìwo̩ fúnraàre̩ ti fún wa rúbo̩ sí O̩,
e̩bo̩ ìlàjà pípé.

Baba mímó̩, àwa ń fi ìrè̩lè̩ bè̩ Ó̩,
kí O gbà wá bákan náà,
pè̩lú O̩mo̩ ò̩ Re̩,
àti nínú oúnje̩ ìgbàlà yìí.
Fi È̩míi Rè̩ fún wa,
E̩ni tí Ó kó gbogbo àwo̩n ohun ìkò̩sè̩
tó ń fa ìyapa kúrò láàárín wa.

Jé̩ kí ó so̩ Ìjo̩ ò̩ Re̩ di àmì ìré̩pò̩
àti ohun èlò àlàáfíà láàárín gbogbo è̩dá,
kí ó sì pa wá mó̩ nínú ìré̩pò̩
pè̩lú u  [red][b]N.[/b][/red] Pápà a wa àti   
[red][b]N.[/b][/red] Bís̩ó̩ò̩bù u wa.
pè̩lú gbogbo àwo̩n Bís̩ó̩ò̩bù
àti gbogbo àwo̩n ènìyàn Re̩.

Bí O ti s̩e kó wa jo̩pò̩ ní oríi pe̩pe̩ O̩mo̩ ò̩ Re̩ nísinsìnyí
dà wá pò̩ pè̩lúu
Màríà Wúndíá ológo, Ìyá O̩ló̩run
pè̩lú u Jósé̩fù alábùkún-fún o̩ko̩ rè̩
pè̩lú àwo̩n Àpóstólì alábùkún-fún
àti gbogbo àwo̩n ènìyàn mímó̩
pè̩lú àwo̩n ará a wa
àti àwo̩n ènìyàn láti orís̩irís̩i è̩yà àti èdè
tí wó̩n ti kú ní ìré̩pò̩ pè̩lú ù Re̩.
Mú wa jé̩ alábàápín nínú oúnje̩ àsè àìlópin ti ìré̩pò̩
ní ò̩run tuntun àti ayé tuntun,
níbi tí a óò ti je̩ ìgbádùn è̩kúnré̩ré̩ àlàáfíà Re̩
nínú Jésù Krístì Olúwa wa.
"
        },
  new EucharisticPrayer
        {
            Number = "VII",
            Title = "Mísà fún  orís̩irís̩i èròǹgbà ìkínní",
            Season = "Àdúra Yukaristí fún orís̩irís̩i èròǹgbà I",
            Comment = null,
            Text = @" Fún Ìjo̩ nínú ìrìnàjò ìré̩pò̩
    [red][i]A lè lo Àdúra Yukaristí kìnní (I) fún orís̩irís̩i èròǹgbà nínú àwo̩n Mísà wò̩nyí: Fún Ìjo̩, Fún Pápà, Fún Bís̩ó̩ò̩bù, Fún yíyan Pápà tàbí Bís̩ó̩ò̩bù, Fún àpérò Ìjo̩, Fún Àlùfáà, Fún Àlùfáà fúnrarè̩, Fún àwo̩n òs̩ìsé̩ nínú Ilé-O̩ló̩run tàbí Fún àpérò Ìjo̩.
    Àlùfáà nìkan yóò gbàdúrà báyìí pé:[/i][/red]

Nítòótó̩ mímó̩ ni Ìwo̩, ó sì ye̩ ká máa yìn Ó̩ lógo
Ìwo̩ O̩ló̩run tí O fé̩ràn àwa ènìyàn
tí O sì wà pè̩lúu wa nínú ìrìnàjo wa ní ayé yìí.
Alábùkún-fún nítòótó̩ ni O̩mo̩ ò̩ Re̩,
E̩ni tí Ó wà láàárín wa
ní gbogbo ìgbà tí a bá pè wa jo̩ pè̩lú ìfé̩ e̩ Rè̩,
bí Ó sì ti s̩e fún àwo̩n o̩mo̩-è̩yin Rè̩ ní ìgbà-a-nì,
Ó ń la Ò̩rò̩ Ìwé Mímó̩ yé wa
Ó sì ń fi oúnje̩-ìyè bó̩ wa.

Nítorí náà, Baba aláàánú jùlo̩,
a ń bè̩bè̩ kí O rán È̩mí Mímó̩ ò̩ Re̩
láti so̩ àwo̩n è̩bùn búré̩dì àti wáìnì yìí di mímó̩
kí wó̩n lè di [red]✠[/red] Ara àti È̩jè̩ Olúwa wa, Jésù Krístì fún wa.

Ní o̩jó̩ tó s̩íwájú o̩jó̩ tí Ó jìyà ikú
ní ibi oúnje̩-alé̩ ìke̩yìn
Ó mú búré̩dì,
Ó súre síi,
Ó sì bù ú
Ó fi í fún àwo̩n o̩mo-è̩yin Rè̩ bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife, Ó fi o̩pé̩ fún O̩,
Ó gbé e fún àwo̩n o̩mo-è̩yin Rè̩ bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.



[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà, bí a ti ń s̩e aye̩ye̩ ìrántí ikú àti àjíǹde O̩mo̩ ò̩ Re̩,
E̩ni tí Ó fi ìlérí ìfé̩ e̩ Rè̩ yìí sílè̩ fún wa
àwa ń fi ohun tí Ìwo̩ fúnraàre̩ ti fún wa rúbo̩ sí O̩,
e̩bo̩ ìlàjà pípé.

Nítorí náà, Baba mímó̩,
bí a ti ń s̩e ìrántíi Krístì O̩mo̩ ò̩ Re̩, Olùgbàla wa,
E̩ni tí Ìwo̩ mú dé ibi ògo àjíǹde
nípasè̩ ìjìyà àti ikú lórí àgbélébùú
tí O sì mú jókòó lápá ò̩tún ùn Re̩ ní ò̩run
àwa ń kéde is̩é̩ àànú ùn Re̩ títí tí Krístì náà yóò fi padà wá,
àwa sì ń fi Oúnje̩ ìyè àti Ife ìbùkún yìí to̩re̩ fún O̩.

Olúwa, fi ojú rere wo e̩bo̩ ti Ìjo̩ ò̩ Re̩,
nínú èyí tí a ń s̩e àfihàn ìjìyà ológo ti Krístì
bí a ti fi lé wa ló̩wó̩:
fifún wa, pé nípa agbára È̩mí ìfé̩ è̩ Re̩,
ká lè kà wá, títí ayérayé, mó̩ àwo̩n e̩gbé̩ O̩mo̩ ò̩ Re̩
E̩ni tí a ń s̩e alábàápín nínú Ara àti È̩je̩ Rè̩.

Olúwa, so̩ Ìjo̩ ò̩ Re̩ [red][b]([/b][/red]èyí tó wà ní 
[red][b]N.)[/b][/red] dò̩tun
nípa agbára ìmó̩lè̩ ìso̩dò̩tun ti Ìyìnrere.
Mú okùn-ìré̩pò̩ láàárín àwo̩n ènìyàn Re̩
àti àwo̩n àlùfáà alábòjútó o wo̩n lágbára síi,
pè̩lú  [red][b]N.[/b][/red] Pápà a wa àti,  [red][b]N.[/b][/red] Bís̩ó̩ò̩bù u wa,
àti gbogbo àwo̩n Bís̩ó̩ò̩bù,
pé nínú ayé yìí tí ìkórìíra àti ò̩tè̩ ń dà láàmú
kí àwo̩n ènìyàn Re̩
lè máa tàn bí àmì ìso̩té̩lè̩ ìré̩pò̩  àti ìs̩ò̩kan.

Rántí àwo̩n arákùnrin àti arábìnrin wa [red][b](N.[/b][/red] àti [red][b]N.)[/b][/red],
tí wó̩n ti ń sinmi nínú àlàáfíà Krístì Re̩
àti gbogbo àwo̩n olóògbé tí ìgbàgbó̩ o̩ wo̩n jé̩ mímò̩ fún Ìwo̩ nìkan:
jé̩ kí wó̩n lè je̩ ìgbádùn ìmó̩lè̩ ojúù Re̩,
kí O sì fún wo̩n ní è̩kúnré̩ré̩ ìyè nínú àjíǹde.

Fifún àwa náà,
pé nígbà tí a bá parí ìrìnàjo wa ní ayé yìí
Kí a lè dé ibi ibùgbé ayérayé
Níbi tí a ó ti máa bá O̩ gbé títí láé
Pè̩lú u Màríà Wúndíá alábùkún-fún, Ìyá O̩ló̩run,
Pè̩lú u Jósé̩fù alábùkún-fún, o̩ko̩ rè̩,
Pè̩lú àwo̩n Àpóstólì, àti àwo̩n Ajé̩rìíkú
[red][b]([/b[/red]pè̩lu [red][b]N.[/b][/red][red][i]: mímó̩ tí a ń s̩e o̩dún un rè̩ lónìí tàbí aláàbò Ilé O̩ló̩run yìí[/i][/red][red][b])[/b][/red]
àti pè̩lú gbogbo àwo̩n ènìyàn mímó̩
Kí a lè máa yìn Ó̩, ká sì máa fi ògo fún O̩
Nípasè̩ e̩ Jésù Krístì, O̩mo̩ ò̩ Re̩.
"
        },
   new EucharisticPrayer
        {
            Number = "VIII",
            Title = "Mísà fún orís̩irís̩i èròǹgbà ìkejì",
            Season = "Àdúra Yukaristí fún orís̩irís̩i èròǹgbà II",
            Comment = null,
            Text = @"O̩ló̩run tí Ó ń darí Ìjo̩ Rè̩ ní ò̩nà ìgbàlà
    [red][i]A lè lo Àdúra Yukaristí ìkejì (II) fún  orís̩irís̩i èròǹgbà nínú àwo̩n Mísà wò̩nyí: Fún Ìjo̩, Fún Ìjé̩-ìpe-rere sí Is̩é̩ Àlùfáà, Fún àwo̩n O̩mo̩-Ìjo̩, Fún Ìdílé, Fún àwo̩n Olùfo̩kànsìn, Fún Ìjé̩-ìpè rere sí is̩é̩ Olùfo̩kànsìn, Fún ìto̩re̩ àánú, Fún àwo̩n e̩bí tàbí ò̩ré̩, àti Fún Ìdúpé̩ sí O̩ló̩run.
    Àlùfáà nìkan yóò gbàdúrà báyìí pé:[/i][/red]

Nítòótó̩ mímó̩ ni Ìwo̩, ó sì ye̩ ká máa yìn Ó̩ lógo
Ìwo̩ O̩ló̩run tí O fé̩ràn àwa ènìyàn
tí O sì wà pè̩lúu wa nínú ìrìnàjo wa ní ayé yìí.
Alábùkún-fún nítòótó̩ ni O̩mo̩ ò̩ Re̩,
E̩ni tí Ó wà láàárín wa
ní gbogbo ìgbà tí a bá pè wa jo̩ pè̩lú ìfé̩ è̩ Rè̩,
bí Ó sì ti s̩e fún àwo̩n o̩mo̩-è̩yìn Rè̩ ní ìgbà-a-nì,
Ó ń la Ò̩rò̩ Ìwé Mímó̩ yé wa
Ó sì ń fi oúnje̩-ìyè bó̩ wa.

Nítorí náà, Baba aláàánú jùlo̩,
a ń bè̩bè̩ kí O rán È̩mí Mímó̩ ò̩ Re̩
láti so̩ àwo̩n è̩bùn búré̩dì àti wáìnì yìí di mímó̩
kí wó̩n lè di  [red]✠[/red] Ara àti È̩jè̩ Olúwa wa, Jésù Krístì fún wa.

Ní o̩jó̩ tó s̩íwájú o̩jó̩ tí Ó jìyà ikú
ní ibi oúnje̩-alé̩ ìke̩yìn
Ó mú búré̩dì,
Ó súre síi,
Ó sì bù ú
Ó fi í fún àwo̩n o̩mo̩-è̩yin Rè̩
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife, Ó fi o̩pé̩ fún O̩,
Ó gbé e fún àwo̩n o̩mo-è̩yin Rè̩ bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.



[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà, Baba mímó̩,
bí a ti ń s̩e ìrántí i Krístì O̩mo̩ ò̩ Re̩, Olùgbàla wa,
E̩ni tí Ìwo̩ mú dé ibi ògo àjíǹde
nípasè̩ ìjìyà àti ikú lórí àgbélébùú
tí O sì mú u jókòó lápá ò̩tún ùn Re̩ ní ò̩run
àwa ń kéde is̩é̩ àànú ùn Re̩
títí tí Krístì náà yóò fi padà wa,
àwa sì ń fi oúnje̩ ìyè àti Ife ìbùkún yìí to̩re̩ fún O̩.

Olúwa, fi ojú rere wo e̩bo̩ ti Ìjo̩ ò̩ Re̩,
nínú èyí tí a ń s̩e àfihàn ìjìyà ológo ti Krístì
bí a ti fi lé wa ló̩wó̩:
fifún wa, pé nípa agbára È̩mí ìfé̩ è̩ Re̩,
kí á lè kà wá, nísinsìnyí àti títí ayérayé,
mó̩ àwo̩n e̩gbé̩ O̩mo̩ ò̩ Re̩
E̩ni tí a ń s̩e alábàápín nínú Ara àti È̩je̩ Rè̩.

Nítorí náà, Olúwa,
bí O ti pè wá láti jé̩ alábàápín ní oríi pe̩pe̩ è̩ Re̩
mú e̩sè̩ e̩ wa dúró s̩ins̩in nínú ìs̩ò̩kan,
pé, pè̩lú  [red][b]N.[/b][/red] Pápà a wa àti  [red][b]N.[/b][/red] Bís̩ó̩ò̩bù u wa,
pè̩lú gbogbo àwo̩n Bís̩ó̩ò̩bù, àwo̩n àlùfáà, àwo̩n díákónì,
àti gbogbo àwo̩n ènìyàn Re̩,
ká lè máa rìn ní ò̩nà Re̩ pè̩lú ìgbàgbó̩ àti ìrètí
ká sì lè ye̩ láti mú ò̩pò̩ ayò̩ àti ìs̩òtìító̩ wá sínú ayé.

Rántí àwo̩n arákùnrin àti arábìnrin wa  [red][b](N.[/b][/red] àti [red][b]N.)[/b][/red],
tí wó̩n ti ń sinmi nínú àlàáfíà Krístì Re̩
àti gbogbo àwo̩n olóògbé
tí ìgbàgbó̩ wo̩n jé̩ mímò̩ fún Ìwo̩ nìkan:
jé̩ kí wó̩n lè je̩ ìgbádùn ìmó̩lè̩ ojúù Re̩,
kí O sì fún wo̩n ní è̩kúnré̩ré̩ ìyè nínú àjíǹde.

Fifún àwa náà,
pé nígbà tí a bá parí ìrìnàjo wa ní ayé yìí
ká lè dé ibi ibùgbé ayérayé
níbi tí a óò ti máa bá O̩ gbé títí láé
pè̩lúu Màríà Wúndíá alábùkún-fún, Ìyá O̩ló̩run,
pè̩lú Jósé̩fù alábùkún-fún, o̩ko̩ rè̩,
pè̩lú àwo̩n Àpóstólì, àti àwo̩n Ajé̩rìíkú
[red][b]([/b][/red]pè̩lu [red][b]N.[/b][/red][red][i]: mímó̩ tí a ń s̩e o̩dún un rè̩ lónìí tàbí aláàbò Ilé O̩ló̩run yìí[/i][/red][red][b])[/b][/red]
àti pè̩lúu gbogbo àwo̩n ènìyàn mímó̩
ká lè máa yìn Ó̩, ká sì máa fi ògo fún O̩
nípasè̩ e̩ Jésù Krístì, O̩mo̩ ò̩ Re̩.

"
        },
   new EucharisticPrayer
        {
            Number = "IX",
            Title = "Mísà fún  orís̩irís̩i èròǹgbà ìke̩ta",
            Season = "Àdúra Yukaristí fún orís̩irís̩i èròǹgbà III",
            Comment = null,
            Text = @"Jésù, ò̩nà tó lo̩ só̩dò̩ Baba
    [red][i]A lè lo Àdúra Yukaristí ìke̩ta(III) Fún  orís̩irís̩i èròǹgbà nínú àwo̩n Mísà wò̩nyí: Fún Ìjo̩, Fún Pápà, Fún Bís̩ó̩ò̩bù, Fún yíyan Pápà tàbí Bís̩ó̩ò̩bù, Fún àpérò Ìjo̩, Fún Àlùfáà, Fún Àlùfáà fúnrarè̩, Fún àwo̩n òs̩ìsé̩ nínú Ilé-O̩ló̩run tàbí Fún àpérò Ìjo̩. 
    Àlùfáà nìkan yóò gbàdúrà báyìí pé:[/i][/red]

Nítòótó̩ mímó̩ ni Ìwo̩, ó sì ye̩ ká máa yìn Ó̩ lógo
Ìwo̩ O̩ló̩run tí O fé̩ràn àwa ènìyàn
tí O sì wà pè̩lúu wa nínú ìrìnàjo wa ní ayé yìí.
Alábùkún-fún nítòótó̩ ni O̩mo̩ ò̩ Re̩,
E̩ni tí Ó wà láàárín wa
ní gbogbo ìgbà tí a bá pè wá jo̩ pè̩lú ìfé̩ è̩ Rè̩,
bí Ó sì ti s̩e fún àwo̩n o̩mo̩-è̩yin Rè̩ ní ìgbà-a-nì,
Ó ń la Ò̩rò̩ Ìwé Mímó̩ yé wa
Ó sì ń fi oúnje̩-ìyè bó̩ wa.

Nítorí náà, Baba aláàánú jùlo̩,
a ń bè̩bè̩ kí O rán È̩mí Mímó̩ ò̩ Re̩
láti so̩ àwo̩n è̩bùn búré̩dì àti wáìnì yìí di mímó̩
kí wó̩n lè di [red]✠[/red] Ara àti È̩jè̩ Olúwa wa, Jésù Krístì fún wa. 

Ní o̩jó̩ tó s̩íwájú o̩jó̩ tí Ó jìyà ikú
ní ibi oúnje̩-alé̩ ìke̩yìn
Ó mú búré̩dì,
Ó súre síi,
Ó sì bù ú
Ó fi í fún àwo̩n o̩mo-è̩yin Rè̩
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife, Ó fi o̩pé̩ fún O̩,
Ó gbé e fún àwo̩n o̩mo̩-è̩yin Rè̩
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ MU NÍNÚ UN RÈ̩:
ÈYÍ NI IFE TI È̩JÈ̩ MI,
È̩JÉ̩ E̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ,
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN
FÚN ÌDÁRÍJÌ È̩S̩È̩.
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ Ì MI.


[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà, Baba mímó̩,
bí a ti ń s̩e ìrántíi Krístì O̩mo̩ ò̩ Re̩, Olùgbàla wa,
E̩ni tí Ìwo̩ mú dé ibi ògo àjíǹde
nípasè̩ ìjìyà àti ikú lórí àgbélébùú
tí O sì mú jókòó lápá ò̩tún ùn Re̩ ní ò̩run
àwa ń kéde is̩é̩ àànú ùn Re̩ títí tí Krístì náà yóò fi padà wa,
àwa sì ń fi oúnje̩ ìyè àti Ife ìbùkún yìí to̩re̩ fún O̩.

Olúwa, fi ojú rere wo e̩bo̩ ti Ìjo̩ ò̩ Re̩,
nínú èyí tí a ń s̩e àfihàn ìjìyà ológo ti Krístì
bí a ti fi lé wa ló̩wó̩:
fifún wa, pé nípa agbára È̩mí ìfé̩ è̩ Re̩,
ká lè kà wá, nísinsìnyí àti títí ayérayé,
mó̩ àwo̩n e̩gbé̩ O̩mo̩ ò̩ Re̩
E̩ni tí a ń s̩e alábàápín nínú Ara àti È̩je̩ Rè̩.

Baba alagbara jùlo̩,
nípa ìbápín wa nínú ohun-ìjìnlè̩ yìí
fi È̩mí Mímó̩ ò̩ Re̩ ró wa ní agbára.
Fifún wa, ká lè tè̩lé àpe̩re̩ O̩mo̩ ò̩ Re̩,
kí O sì fi okùn ìré̩pò̩ gbé wa ró nínú ìs̩ò̩kan
pè̩lú [red][b]N.[/b][/red] Pápà a wa àti  [red][b]N.[/b][/red] Bís̩ó̩ò̩bù u wa,
pè̩lú gbogbo àwo̩n Bís̩ó̩ò̩bù tó kù, 
àwo̩n àlùfáà àti díákónì,
àti gbogbo àwo̩n ènìyàn Re̩.

Jé̩ kí gbogbo àwo̩n onígbàgbó̩ Ìjo̩ ò̩ Re̩
lè máa s̩e às̩àrò lórí àwo̩n ìs̩è̩lè̩ àsìkò yìí
pè̩lú ìtàná ìgbàgbó̩
kí wó̩n sì lè máa fi ara wo̩n jì
láìbojúwo-è̩yìn fún is̩é̩ Ìyìnrere.
Ràn wá ló̩wó̩ láti lè mo̩ àìní i 
gbogbo àwo̩n arákùnrin àti arábìnrin wa
ká lè bá wo̩n pín nínú è̩dùn-o̩kàn àti ìnira wo̩n,
nínú ayò̩ àti ìrètí i wo̩n,
ká lè kéde ìròyìn ìdáǹdè fún wo̩n pè̩lú òtító̩,
ká sì lè máa tè̩siwaju pè̩lúu wo̩n nínú ìrìnàjò ìjo̩ba à Re̩.

Rántí àwo̩n arákùnrin àti arábìnrin wa [red][b](N.[/b][/red] àti [red][b]N.)[/b][/red],
tí wó̩n ti ń sinmi nínú àlàáfíà Krístì Re̩
àti gbogbo àwo̩n olóògbé
tí ìgbàgbó̩ wo̩n jé̩ mímò̩ fún Ìwo̩ nìkan:
jé̩ kí wó̩n lè je̩ ìgbádùn ìmó̩lè̩ ojúù Re̩,
kí O sì fún wo̩n ní è̩kúnré̩ré̩ ìyè nínú àjíǹde.

Fifún àwa náà,
pé nígbà tí a bá parí ìrìnàjo wa ní ayé yìí
ká lè dé ibi ibùgbé ayérayé
níbi tí a óò ti máa bá O̩ gbé títí láé
pè̩lúu Màríà Wúńdíá alábùkún-fún, Ìyá O̩ló̩run,
pè̩lú Jósé̩fù alábùkún-fún, o̩ko̩ rè̩,
pè̩lú àwo̩n Àpóstólì, àti àwo̩n Ajé̩rìíkú,
[red][b]([/b][/red]pè̩lu [red][b]N.[/b][/red][red][i]: mímó̩ tí a ń s̩e o̩dún un rè̩ lónìí tàbí aláàbò Ilé O̩ló̩run yìí[/i][/red][red][b])[/b][/red]
àti pè̩lúu gbogbo àwo̩n ènìyàn mímó̩
ká lè máa yìn Ó̩, ká sì máa fi ògo fún O̩
nípasè̩ e̩ Jésù Krístì, O̩mo̩ ò̩ Re̩.

"
        },
   new EucharisticPrayer
        {
            Number = "X",
            Title = "Mísà fún  orís̩irís̩i èròǹgbà ìke̩rin (IV)",
            Season = "Àdúra Yukaristí fún orís̩irís̩i èròǹgbà IV",
            Comment = null,
            Text = @"Jésù, akiri-s̩oore
    [red][i]A lè lo Àdúra Yukaristí ìke̩rin (IV) fún  orís̩irís̩i èròǹgbà nínú àwo̩n Mísà wò̩nyí: Fún àwo̩n tí a lé kúrò lórí ilè̩ e̩ wo̩n, Ní ìgbà ìyàn àti ebi, Fún àwo̩n tó ń niwá lárà, Fún àwo̩n tí wó̩n wà nínú ìgbèkùn, Fún àwo̩n tí a tì mó̩ è̩wò̩n, Fún àwo̩n aláìsàn, Fún àwo̩n tó ń kú lo̩, Fún oore-ò̩fé̩ ikú rere, àti Fún àwo̩n àìníi wa.
    Àlùfáà nìkan yóò gbàdúrà báyìí pé:
[/i][/red]

Nítòótó̩ mímó̩ ni Ìwo̩, ó sì ye̩ ká máa yìn Ó̩ lógo
Ìwo̩ O̩ló̩run tí O fé̩ràn àwa ènìyàn
tí O sì wà pè̩lúu wa nínú ìrìnàjo wa ní ayé yìí.
Alábùkún-fún nítòótó̩ ni O̩mo̩ ò̩ Re̩,
E̩ni tí Ó wà láàárín wa
ní gbogbo ìgbà tí a bá pè wa jo̩ pè̩lú ìfé̩ è̩ Rè̩,
bí Ó sì ti s̩e fún àwo̩n o̩mo̩-è̩yin Rè̩ ní ìgbà-a-nì,
Ó ń la Ò̩rò̩ Ìwé Mímó̩ yé wa
Ó sì ń fi oúnje̩-ìyè bó̩ wa.

Nítorí náà, Baba aláàánú jùlo̩,
a ń bè̩bè̩ kí O rán È̩mí Mímó̩ ò̩ Re̩
láti so̩ àwo̩n è̩bùn búré̩dì àti wáìnì yìí di mímó̩
kí wó̩n lè di [red]✠[/red] Ara àti È̩jè̩ Olúwa wa, Jésù Krístì fún wa.

Ní o̩jó̩ tó s̩íwájú o̩jó̩ tí Ó jìyà ikú
ní ibi oúnje̩-alé̩ ìke̩yìn
Ó mú búré̩dì,
Ó súre síi,
Ó sì bù ú
Ó fi í fún àwo̩n o̩mo-è̩yin Rè̩ 
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN,
KÍ E̩ SÌ JE̩ NÍNÚ UN RÈ̩:
ÈYÍ NI ARA À MI
TÍ A Ó FI JÌ FÚN UN YÍN.

Bákan náà,
nígbà tí wó̩n je̩ oúnje̩-alé̩ tán,
Ó gbé ife, Ó fi o̩pé̩ fún O̩,
Ó gbé e fún àwo̩n o̩mo̩-è̩yin Rè̩
bí Ó ti ń wípé:

E̩ GBA ÈYÍ, GBOGBO YÍN, 
KÍ E̩ SÌ MU NÍNÚ RÈ̩: 
ÈYÍ NI IFE TI È̩JÈ̩ MI, 
È̩JÉ̩ MÁJÈ̩MU TUNTUN ÀTI AYÉRAYÉ, 
TÍ A Ó TA SÍLÈ̩ FÚN UN YÍN 
ÀTI FÚN Ò̩PÒ̩ ÈNÌYÀN FÚN ÌDÁRÍJÌ È̩S̩È̩. 
E̩ MÁA S̩E ÈYÍ NÍ ÌRÁNTÍ MI.


[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]

Ohun-ìjìnlè̩ ìgbàgbó̩.


 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]

Nítorí náà, Baba mímó̩,
bí a ti ń s̩e ìrántí Krístì O̩mo̩ ò̩ Re̩, Olùgbàla wa,
E̩ni tí Ìwo̩ mú dé ibi ògo àjíǹde
nípasè̩ ìjìyà àti ikú lórí àgbélébùú
tí O sì mú jókòó lápá ò̩tún ùn Re̩ ní ò̩run
àwa ń kéde is̩é̩ àànú ùn Re̩ títí tí Krístì náà yóò fi padà wá,
àwa sì ń fi oúnje̩ ìyè àti Ife ìbùkún yìí to̩re̩ fún O̩.

Olúwa, fi ojú rere wo e̩bo̩ ti Ìjo̩ ò̩ Re̩,
nínú èyí tí a ń s̩e àfihàn ìjìyà ológo ti Krístì
bí a ti fi lé wa ló̩wó̩:
fifún wa, pé nípa agbára È̩mí ìfé̩ è̩ Re̩,
ká lè kà wá, nísinsìnyí àti títí ayérayé,
mó̩ àwo̩n e̩gbé̩ O̩mo̩ ò̩ Re̩
E̩ni tí a ń s̩e alábàápín nínú Ara àti È̩je̩ Rè̩.

Olúwa, mú Ìjo̩ ò̩ Re̩ dé ibi às̩epé ìgbàgbó̩ àti àànú
pè̩lú  [red][b]N.[/b][/red] Pápà a wa àti  [red][b]N.[/b][/red] Bís̩ó̩ò̩bù u wa,
pè̩lú gbogbo àwo̩n Bís̩ó̩ò̩bù, 
àwo̩n àlùfáà àti díákónì,
àti gbogbo àwo̩n ènìyàn tí Ìwo̩ ti so̩ di tìre̩.

Là wá loju, láti rí, àti láti mo̩ àìní àwo̩n ará a wa;
fún wa ní oore-ò̩fé̩
láti lè s̩e is̩é̩ ìrànló̩wó̩ fún àwo̩n tó wà ní abé̩ àjàgà
nípa ò̩rò̩ àti ìs̩e wa;
jé̩ ká lè jé̩ olùrànló̩wó̩ tòótó̩ fún wo̩n
bí a ti ń tè̩lé àpe̩re̩ àti ìlàna Krístì.
Jé̩ kí Ìjo̩ ò̩ Re̩ farahàn gé̩gé̩ bí àmì òtító̩, òmìnira,
àlàáfíà àti òdodo,
kí gbogbo àwo̩n ènìyàn
sì lè dúró s̩ins̩in nínú ìrètí tuntun.

Rántí àwo̩n arákùnrin àti arábìnrin wa [red][b](N.[/b][/red] àti [red][b]N.)[/b][/red],
tí wó̩n ti ń sinmi nínú àlàáfíà Krístì Re̩
àti gbogbo àwo̩n olóògbé
tí ìgbàgbó̩ wo̩n jé̩ mímò̩ fún Ìwo̩ nìkan:
jé̩ kí wó̩n lè je̩ ìgbádùn ìmó̩lè̩ ojúù Re̩,
kí O sì fún wo̩n ní è̩kúnré̩ré̩ ìyè nínú àjíǹde.

Fifún àwa náà,
pé nígbà tí a bá parí ìrìnàjo wa ní ayé yìí
ká lè dé ibi ibùgbé ayérayé
níbi tí a óò ti máa bá O̩ gbé títí láé
pè̩lúu Màríà Wúńdíá alábùkún-fún, Ìyá O̩ló̩run,
pè̩lúu Jósé̩fù alábùkún-fún, o̩ko̩ rè̩,
pè̩lú àwo̩n Àpóstólì, àti àwo̩n Ajé̩rìíkú

[red][b]([/b][/red]pè̩lu [red][b]N.[/b][/red][red][i]: mímó̩ tí a ń s̩e o̩dún un rè̩ lónìí tàbí aláàbò Ilé O̩ló̩run yìí[/i][/red][red][b])[/b][/red]
àti pè̩lúu gbogbo àwo̩n ènìyàn mímó̩
ká lè máa yìn Ó̩, ká sì máa fi ògo fún O̩
nípasè̩ e̩ Jésù Krístì, O̩mo̩ ò̩ Re̩."
        },
   new EucharisticPrayer
        {
            Number = "XI",
            Title = null,
            Season = "(Fi Pamò̩)",
            Comment = null,
            Text = @"[red][i]Lé̩yìn Àdúrà Ìyípadà Àlùfáà yóò wípé:[/i][/red]


Ohun-ìjìnlè̩ ìgbàgbó̩.

 
[b]Àwa ń kéde ikú ù Re̩, Olúwa, 
a sì ń jé̩wó̩ àjíǹde è Re̩ 
títí Ìwo̩ yóò tún padà wá.[/b]

[red]Tàbí:[/red]
[b]Ní gbogbo ìgbà tí a bá ń je̩ búré̩dì yìí,
tí a sì ń mu nínú ife yìí,
àwa ń kéde ikú ù Re̩ Olúwa,
títí Ìwo̩ yóò fi padà wá.[/b]

[red]Tàbí:[/red]
[b]Olùgbàlà aráyé,
Ìwo̩ ti dá wa nídè nípa àgbélébùú àti àjíǹde Re̩
jò̩wó̩ gbà wá là.[/b]"
        },
        // Add all 11 prayers here
    };
    

        // Get communicantes for specific Eucharistic Prayer (only Prayer I has communicantes)
        public static List<Communicantes> GetCommunicantesForPrayer(string prayerNumber, string selectedSeason = "Usual Form")
        {
            if (prayerNumber != "I")
            {
                return new List<Communicantes>(); // Empty list for non-Prayer I
            }

            var prayerOne = GetPrayers().FirstOrDefault(p => p.Number == "I");
            return prayerOne?.CommunicantesList?.Where(c => c.Season == selectedSeason).ToList() ?? new List<Communicantes>();
        }

        // Get default communicantes (Usual Form for Prayer I)
        public static Communicantes GetDefaultCommunicantes()
        {
            return GetCommunicantesForPrayer("I", "Usual Form").FirstOrDefault();
        }

        // Check if prayer has communicantes
        public static bool HasCommunicantes(string prayerNumber)
        {
            return prayerNumber == "I";
        }
    }
}
