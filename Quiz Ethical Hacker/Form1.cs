using System;
using System.Windows.Forms;
using System.Net.Mail;

namespace Quiz_Ethical_Hacker
{
    public partial class Form1 : Form
    {
        // variables list for this quiz game
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int percentage;
        int totalQuestions;
        public Form1()
        {
            InitializeComponent();
            AskQuestion(questionNumber);
            totalQuestions = 126;
        }

        private void CheckAnswerEvent(object sender, EventArgs e)
        {
            var senderObject = (Button)sender;
            int buttonTag = Convert.ToInt32(senderObject.Tag);

            if (buttonTag == correctAnswer)
            {
                score++;
            }

            if (questionNumber == totalQuestions)
            {
                // work out the percentage here
                percentage = (int)Math.Round((double)(100 * score) / totalQuestions);
                MessageBox.Show
                    ("Quiz Ended" + Environment.NewLine +
                                "You have answered " + score + " questions correcly" + Environment.NewLine +
                                "Your total percentage is " + percentage + " %" + Environment.NewLine + Environment.NewLine +
                                "Click Ok to play again"

                    );

                score = 0;
                questionNumber = 0;
                AskQuestion(questionNumber);
            }

            questionNumber++;
            AskQuestion(questionNumber);
        }

        private void AskQuestion(int qnum)
        {
            switch (qnum)
            {
                case 1: // Quiz 1
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Zeichen wird das Home-Verzeichnis eines Benutzers gekennzeichnet?";

                    Btn1.Text = "-";
                    Btn2.Text = "./";
                    Btn3.Text = "..";
                    Btn4.Text = "~";

                    correctAnswer = 4;
                    break;
                case 2:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Befehl wird das Passwort des Benutzers kali auf einem Linux-System geändert?";

                    Btn1.Text = "# kali password";
                    Btn2.Text = "# passwd";
                    Btn3.Text = "# set passwd";
                    Btn4.Text = "# /etc/passwd";

                    correctAnswer = 2;
                    break;
                case 3:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie werden auf der Kommandozeile unter Linux die versteckten Dateien angezeigt?";

                    Btn1.Text = "ls -a";
                    Btn2.Text = "ls -l";
                    Btn3.Text = "pwd";
                    Btn4.Text = "cd -";

                    correctAnswer = 1;
                    break;
                case 4:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welcher Option werden die Rechte einer Datei angezeigt?";

                    Btn1.Text = "ls -a";
                    Btn2.Text = "cd -a";
                    Btn3.Text = "ls -l";
                    Btn4.Text = "pwd -l";

                    correctAnswer = 3;
                    break;
                case 5:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie gelangt man in das vorhergehende Verzeichnis?";

                    Btn1.Text = "cd ..";
                    Btn2.Text = "cd ~";
                    Btn3.Text = "cd /";
                    Btn4.Text = "cd-";

                    correctAnswer = 4;
                    break;
                case 6:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher Befehl wechselt aus dem Verzeichnis /usr/share/windows-binaries in das Home-Verzeichnis des Benutzers kali?";

                    Btn1.Text = "cd /usr/share/windows-binaries /home/kali";
                    Btn2.Text = "cd /home/root";
                    Btn3.Text = "cd ../../../home/kali";
                    Btn4.Text = "cd ./home/kali";

                    correctAnswer = 3;
                    break;
                case 7:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Zeile steht in der Regel am Anfang eines Shellskripts?";

                    Btn1.Text = "!#/bash";
                    Btn2.Text = "Es gibt keine erste Zeile.";
                    Btn3.Text = "#!/bin/sh";
                    Btn4.Text = "!#/bin/python3";

                    correctAnswer = 3;
                    break;
                case 8:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Kommando wird ein Skript unter Linux ausführbar gemacht?";

                    Btn1.Text = "chown root:root <Dateiname>";
                    Btn2.Text = "chmod +x <Scriptname>";
                    Btn3.Text = "chmod +ux <Skriptname>";
                    Btn4.Text = "chown user +x <Skriptname>";

                    correctAnswer = 2;
                    break;
                case 9:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher Befehl sucht nach allen Fundstellen, die 'gulugulu' enthalten und sich im Verzeichnis /etc befinden?";

                    Btn1.Text = "locate gulugulu | grep ^/etc";
                    Btn2.Text = "grep gulugulu ^/etc";
                    Btn3.Text = "locate gulugulu '/etc'";
                    Btn4.Text = "grep ^/etc gulugulu";

                    correctAnswer = 1;
                    break;
                case 10:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie kannst du dir Hilfe zu einem Befehl, Programm, Dienst oder einer Konfigurationsdatei anzeigen lassen?";

                    Btn1.Text = "help";
                    Btn2.Text = "find";
                    Btn3.Text = "which";
                    Btn4.Text = "man";

                    correctAnswer = 4;
                    break;
                case 11:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden IP-Adressen kannst du wählen, wenn dein Gateway die IP-Adresse 192.168.178.1 hat und die Subnetzmaske in deinem lokalen Netzwerk 255.255.255.0 ist?";

                    Btn1.Text = "192.168.10.2";
                    Btn2.Text = "192.168.178.254";
                    Btn3.Text = "192.168.178.1";
                    Btn4.Text = "192.168.177.100";

                    correctAnswer = 2;
                    break;
                case 12:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie kannst du in Kali Linux im Repository nach einem Paket suchen, dass einen Webserver bereitstellt?";

                    Btn1.Text = "apt-get search 'webserver'";
                    Btn2.Text = "apt-get search --keyword 'webserver'";
                    Btn3.Text = "apt-cache 'webserver'";
                    Btn4.Text = "apt-cache search 'websesrver'";

                    correctAnswer = 4;
                    break;
                case 13: // Quiz 2
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Art der Sicherheitsanalyse wird durchgeführt, wenn der Penetration Tester nur teilweise Kenntnisse der internen Netzstrukturen und Anwendungen einer Organisation hat?";

                    Btn1.Text = "White-Box";
                    Btn2.Text = "Announced";
                    Btn3.Text = "Black-Box";
                    Btn4.Text = "Grey-Box";

                    correctAnswer = 4;
                    break;
                case 14:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher Hacker-Typ hat beschränkte oder kaum Kenntnisse im Security-Bereich und weiß lediglich, wie einige einschlägige Hacking-Tools verwendet werden?";

                    Btn1.Text = "Black-Hat-Hacker";
                    Btn2.Text = "White-Hat-Hacker";
                    Btn3.Text = "Script-Kiddies";
                    Btn4.Text = "Cracker";

                    correctAnswer = 3;
                    break;
                case 15:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der im Folgenden genannten Phasen ist die wichtigste Phase im Ethical Hacking, die häufig die längste Zeitspanne in Anspruch nimmt?";

                    Btn1.Text = "Gaining Access";
                    Btn2.Text = "Network Mapping";
                    Btn3.Text = "Privilege Escalation";
                    Btn4.Text = "Footprinting";

                    correctAnswer = 4;
                    break;
                case 16:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Staatlich beauftragte Hacker (nation-state threat actors) entdecken oftmals Schwachstellen, die sie nicht veröffentlichen, um sie zu einem späteren Zeitpunkt gegen das Angriffsziel einzusetzen. Der Stuxnet-Wurm war eine bisher nie dagewesene Malware, da er gleich vier derartige, noch nicht veröffentlichte Vulnerabilities ausnutzte. Wie wird diese Art von Angriff genannt?";

                    Btn1.Text = "Zero Day";
                    Btn2.Text = "Zero Hour";
                    Btn3.Text = "Zero Sum";
                    Btn4.Text = "No Day";

                    correctAnswer = 1;
                    break;
                case 17:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein CEH-zertifizierter Ethical Hacker wird von einer Freundin angesprochen. Sie erklärt ihm, dass sie befürchtet, ihr Ehemann würde sie betrügen. Sie bietet dem Ethical Hacker eine Bezahlung an, damit er in den E-Mail-Account des Freundes einbricht, um Beweise zu finden. Was wird er ihr antworten?";

                    Btn1.Text = "Er lehnt ab, da der Account nicht der Freundin gehört.";
                    Btn2.Text = "Er sagt zu, da der Ehemann unethisch handelt und die Freundin Hilfe braucht.";
                    Btn3.Text = "Er sagt zu, lehnt aber die Bezahlung ab, da es sich um einen Freundschaftsdienst handelt.";
                    Btn4.Text = "Er lehnt ab und erklärt der Freundin, welcher Gefahr sie ihn damit aussetzt.";

                    correctAnswer = 1;
                    break;
                case 18:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Sibylle ist CEH-zertifiziert und arbeitet seit Kurzem in einem größeren Handwerksbetrieb, wo die meisten Mitarbeiter nur sehr geringe IT-Kenntnisse haben. Sie entdeckt zahlreiche Sicherheitsschwachstellen, unter anderem Passwörter, die sich die Mitarbeiter teilen, Passwörter, die als Notiz am Bildschirm kleben, Bildschirme, die nicht gesperrt werden, wenn der Arbeitsplatz verlassen wird, dauerhafte Anmeldungen bei Social Media-Plattformen ohne sich auszuloggen, etc.Nachdem Sie mit ihrem Chef darüber gesprochen hat, führt sie einige Sicherheitsverbesserungen in der Firma ein.Als erstes möchte sie den Mitarbeitern begreiflich machen, wie wichtig es ist, vertrauliche Informationen, wie Passwörter und persönliche Accounts(E-Mail, Social Media, etc.) zu schützen und nicht mit anderen zu teilen. Welchen der folgenden Schritte wird sie als erstes machen, um dieses Ziel zu erreichen ? ";

                    Btn1.Text = "Sie veranstaltet ein Security Awareness Trainging.";
                    Btn2.Text = "Sie spricht mit allen Mitarbeitern die ihr Passwort als Post-It an den Monitor geklebt oder anderweitig sichtbar offengelegt haben und fordert diese auf, die Zugangsdaten zu schützen.";
                    Btn3.Text = "Sie entwickelt eine strickte Sicherheitsrichtlinie für das Unternehmen.";
                    Btn4.Text = "Sie führt ein vier-Augen-Gespräch mit jedem Mitarbeiter durch, um die Wichtigkeit der IT-Sicherheit zu verdeutlichen.";

                    correctAnswer = 2;
                    break;
                case 19:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der im Folgenden genannten Methoden bietet eine bessere ROI-Prüfung (Return of Investment) der IT-Security-Investitionen und ermöglicht ein umfassendes Assessment der Security-Policy des Unternehmens, der Prozesse und der Implementation der Sicherheitsmechanismen?";

                    Btn1.Text = "Social Engineering";
                    Btn2.Text = "Vulnerability Scanning";
                    Btn3.Text = "Penetration Testing";
                    Btn4.Text = "Access Control List (ACL) Review";

                    correctAnswer = 3;
                    break;
                case 20:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Die Sicherheitsrichtlinie (Security Policy) definiert die Grundsätze der IT-Security in der Organisation. Für einige Bereiche gibt es ggf. Sub-Policies, wie z.B. Computer-Sicherheitsrichtlinie, Netzwerk-Sicherheitsrichtlinie, Remote-Access-Richtlinie, etc. Welche drei der im folgenden genannten Ziele sollen damit sichergestellt werden?";

                    Btn1.Text = "Availability, Non-repudiation, Confidentiality";
                    Btn2.Text = "Authenciticity, Integrity, Non-repudiation";
                    Btn3.Text = "Confidentility, Integrity, Availability";
                    Btn4.Text = "Authenticity, Confidentiality, Integrity";

                    correctAnswer = 3;
                    break;
                case 21:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie wird der Angriffsvektor genannt, bei dem es darum geht, dass der Angreifer möglichst lange im Zielnetzwerk handlungsfähig bleibt und der oftmals durch Social Engineering initiiert wird?";

                    Btn1.Text = "Malware Attack";
                    Btn2.Text = "Cloud Attack";
                    Btn3.Text = "Insider Attack";
                    Btn4.Text = "Advanced Persistent Threat";

                    correctAnswer = 4;
                    break;
                case 22:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Phase eines Hacking-Angriffs kann die Installation eines Rootkits zugerechnet werden?";

                    Btn1.Text = "Reconnaissance";
                    Btn2.Text = "Scanning";
                    Btn3.Text = "Gaining Access";
                    Btn4.Text = "Maintaining Access";

                    correctAnswer = 4;
                    break;
                case 23: // Quiz 3
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Möglichkeiten ist nicht dazu geeignet, die Anonymität im Internet zu verbessern?";

                    Btn1.Text = "HTTP";
                    Btn2.Text = "Tor";
                    Btn3.Text = "Tail";
                    Btn4.Text = "VPN";

                    correctAnswer = 1;
                    break;
                case 24:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein Security Analyst prüft die Einstellungen eines Computers und stellt fest, dass im Internet Browser die Proxy-Settings so gesetzt sind, dass dieser Computer sich selbst als Proxy-Server nutzen möchte. Welche IP-Adresse ist in den Settings eingetragen?";

                    Btn1.Text = "1.1.1.1";
                    Btn2.Text = "127.0.0.1";
                    Btn3.Text = "Die MAC-Adresse des Computers.";
                    Btn4.Text = "Keine IP-Adresse sondern die entsprechende Option aktiviert.";

                    correctAnswer = 2;
                    break;
                case 25:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Konfiguration muss bei der Anonymisierung via VPNs und ähnlichen Technologien berücksichtigt werden, um die Verfolgung der eigenen Spuren zu erschweren?";

                    Btn1.Text = "Der Tunnelpunkt des VPNs sollte nicht in Deutschland liegen.";
                    Btn2.Text = "Es sollte ein ausländischer Provider gewählt werden.";
                    Btn3.Text = "´SSL-VPNs sind sicherer als ipsec-VPNs und sollten daher bevorzugt werden.";
                    Btn4.Text = "DNS-Anfragen sollten durch den Tunnel geleitet werden.";

                    correctAnswer = 4;
                    break;
                case 26:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Technologien wird nicht als Tunneltechnologie genutzt?";

                    Btn1.Text = "SSL/TLS";
                    Btn2.Text = "Proxy";
                    Btn3.Text = "IPsec";
                    Btn4.Text = "PPTP";

                    correctAnswer = 2;
                    break;
                case 27:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Worin besteht der Unterschied zwischen Deep Web und Darknet?";

                    Btn1.Text = "Das Darknet ist ein Netzwerk für Hacker während das Deepweb für alle zugänglich ist.";
                    Btn2.Text = "Darkweb und Deepweb werden anonym genutzt und haben inhaltlich keine Unterschiede.";
                    Btn3.Text = "Das Darknet ist ein weltumspannendes Netzwerk unter der Oberfläche des sichtbaren Internets, während das Deepweb aus vielen einzelnen Netzen besteht.";
                    Btn4.Text = "Ein Darknet ist ein geschlossenes, nach außen nicht sichtbares Netzwerk. Das Deepweb der Teil des Internets, der nicht indiziert und katalogisiert und damit über Suchmaschinen nicht auffindbar ist.";

                    correctAnswer = 4;
                    break;
                case 28:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Adressen kann ausschließlich mit dem Tor-Netzwerk verwendet werden?";

                    Btn1.Text = "6soxyfb3h2nvok2d.onion";
                    Btn2.Text = "6soxyfb3h2nvok2d.tor";
                    Btn3.Text = "6soxyfb3h2nvok2d.de";
                    Btn4.Text = "6soxyfb3h2nvok2d.com";

                    correctAnswer = 1;
                    break;
                case 29:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Kommunikationen wird nicht durch die Anonymizer-Linux-Distribution Tails geschützt?";

                    Btn1.Text = "Email mit Thunderbird";
                    Btn2.Text = "Chat mit Pidgin";
                    Btn3.Text = "Onion Share";
                    Btn4.Text = "Keine der genannten";

                    correctAnswer = 4;
                    break;
                case 30: // Quiz 4
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein Angreifer schneidet verschlüsselten Traffic im Netzwerk mit und ist anschließend in der Lage, diesen zu entschlüsseln. Der Welche der im folgenden genannten Kryptoanalyse-Techniken kann der Angreifer nun nutzen, um den Verschlüsselungsschlüssel zu ermitteln?";

                    Btn1.Text = "Birthday Attack";
                    Btn2.Text = "Plaintext Attack";
                    Btn3.Text = "Meet in the Middle Attack";
                    Btn4.Text = "Chosen Cyphertext Attack";

                    correctAnswer = 4;
                    break;
                case 31:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Aussagen charakterisieren eine Public-Key-Infrastruktur (PKI)?";

                    Btn1.Text = "Public-Key-Kryptosysteme sind schneller als asymmetrische Verschlüsselungsalgorithmen.";
                    Btn2.Text = "Public-Key-Kryptosysteme veröffentlichen und verteilen Public-Keys innerhalb von digitalen Signaturen.";
                    Btn3.Text = "Public-Key-Kryptosysteme benötigen keinen sicheren Kanal zur Übertragung des Verschlüsselungsschlüssels.";
                    Btn4.Text = "Public-Key-Kryptosysteme unterstützen keine Non-Repudiation via Digitaler Signaturen.";

                    correctAnswer = 2;
                    break;
                case 32:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Nachdem der Angreifer Zugriff auf die Passwort-Hashes erlangt hat, die zum Schutz einer web-basierenden Anwendung dienen, kann ihm u. U. Wissen über welchen kryptografischen Algorithmus nützlich sein?";

                    Btn1.Text = "SHA-1";
                    Btn2.Text = "Diffie-Hellman";
                    Btn3.Text = "RSA";
                    Btn4.Text = "AES";

                    correctAnswer = 1;
                    break;
                case 33:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher der folgenden Algorithmen kann eine Zeichenfolge beliebiger Länge in einen Message Digest-Output von 128 Bit Länge verwandeln?";

                    Btn1.Text = "SHA-1";
                    Btn2.Text = "bcrypt";
                    Btn3.Text = "Blowfish";
                    Btn4.Text = "MD5";

                    correctAnswer = 4;
                    break;
                case 34:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was bedeutet 'Collision Attack' in der Kryptografie?";

                    Btn1.Text = "Collision Attacks versuchen zwei Eingaben zu finden, die zum selben Hashwert gehören.";
                    Btn2.Text = "Collision Attacks versuchen den Hashwert in zwei gleich große Teile zu zerlegen, um den privaten Schlüssel zu ermitteln.";
                    Btn3.Text = "Collision Attacks versuchen den Public-Key zu ermitteln.";
                    Btn4.Text = "Collision Attacks versuchen, den Hashwert in drei Teile zu zerlegen, um den Klartext zu ermitteln.";

                    correctAnswer = 1;
                    break;
                case 35:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Form der Sicherheitskontrolle implementiert die Verschlüsselung (Encryption)?";

                    Btn1.Text = "Erkennend (Detective)";
                    Btn2.Text = "Corrective (korrigierend)";
                    Btn3.Text = "Defensive (defensive, verteigigend)";
                    Btn4.Text = "Preventative (vorbeugend)";

                    correctAnswer = 4;
                    break;
                case 36:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches spezifische Sicherheitsziel wird mit Hilfe von Hashes sichergestellt?";

                    Btn1.Text = "Authentication";
                    Btn2.Text = "Confidentiality";
                    Btn3.Text = "Availability";
                    Btn4.Text = "Integrity";

                    correctAnswer = 4;
                    break;
                case 37:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Aussage trifft auf digitale Signaturen zu?";

                    Btn1.Text = "Eine digitale Signatur kann für verschiedene Dokumente des selben Typs verwendet werden.";
                    Btn2.Text = "Eine digitale Signatur kann nicht von einem signierten Dokument auf ein anderes übertragen werden, da die digitale Signatur dem Hashwert über das Dokument entspricht, der mit dem privaten Schlüssel des signierenden verschlüsselt wurde.";
                    Btn3.Text = "Eine digitale Signatur kann nicht von einem signierten Dokument auf ein anderes übertragen werden, da es sich um einen unveränderten Hashwert über das betreffende Dokument handelt.";
                    Btn4.Text = "Digitale Signaturen werden einmal erstellt für einen Benutzer und können von diesem frei verwendet werden, bis zum Ablauf der Gültigkeit.";

                    correctAnswer = 2;
                    break;
                case 38:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welchem Kryptografie-Typ sind SSL, TLS, Diffie Hellman und PGP zuzuordnen?";

                    Btn1.Text = "Secret-Key";
                    Btn2.Text = "Hash-Algorithm";
                    Btn3.Text = "Public-Key";
                    Btn4.Text = "Digest";

                    correctAnswer = 3;
                    break;
                case 39:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Die AVC GmbH hat kürzlich einen neuen Buchhalter (Accountant) eingestellt. Der Buchhalter arbeitet derzeit hauptsächlich am  Jahresabschluss des Unternehmens. Die Ergebnisse müssen vom CFO (Chief Finance Officer) geprüft und unterschrieben zum Buchhalter zurückgesendet werden. Der CFO sorgt sich darum, dass die von ihm abgesegneten Zahlen unbemerkt abgeändert werden könnten. Was kann der CFO tun, um die Daten in seinem Sinne abzusichern?";

                    Btn1.Text = "Er kann die Daten dem Buchhalter auf einem exklusiven USB-Stick mit seinem Namen darauf zukommen lassen.";
                    Btn2.Text = "Die Bilanzdaten können zweimal gesendet werden: einmal per Email und zum anderen per USB. Der Buchhalter kann dann beide Daten vergleichen, um sicherzustellen, dass er dasselbe Dokument erhalten hatdas der CFO gesendet hat.";
                    Btn3.Text = "Der CFO kann einen Hashalgorithmus auf das von ihm abgesegnete Dokument verwenden.";
                    Btn4.Text = "Der CFO kann ein passwortgeschütztes Excel-File versenden.";

                    correctAnswer = 3;
                    break;
                case 40:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was ist der wichtigste Nachteil bei der Verwendung von AES 256 als Verschlüsselungstechnologie, um sensible Daten zu schützen?";

                    Btn1.Text = "Durch seine Schlüsselgröße isdt AES 256 für das Verschlüsseln großer Datenmengen zu langsam und dadurch nicht geeignet.";
                    Btn2.Text = "Um Programme zur Zusammenarbeit mit AES 256 zu bewegen, bedarf es komplexer Konfigurationsschritte.";
                    Btn3.Text = "AES ist ein schwacher Verschlüsselungsalgorithmus, der nach Möglichkeit nicht mehr verwendet werden sollte.";
                    Btn4.Text = "Als symmetrischer Verschlüsselungsalgorithmus erfordert AES die Übermittlung des gemeinsam genutzten Verschlüsselungsschlüssels über einen separaten Übertragungsweg.";

                    correctAnswer = 4;
                    break;
                case 41:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Vanessa reist beruflich bedingt viel und möchte sicherstellen, dass die Daten auf Ihrem Laptop vertraulich bleiben, selbst wenn das Gerät gestohlen wird. Welche Art von Schutz ist am effektivsten?";

                    Btn1.Text = "Versteckter Ordner";
                    Btn2.Text = "Ein starktes, gut geschütztes BIOS/UEFI-Passwort.";
                    Btn3.Text = "Passwort-geschützte Dateien.";
                    Btn4.Text = "Full-Disk-Encryption";
                    correctAnswer = 4;
                    break;
                case 42: // Quiz 5
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Ergebnisse liefert die folgende Google-Suche? site: gulugulu.com - site:marketing.gulugulu.com accounting";

                    Btn1.Text = "Fundstellen die alle angegebenen Wörter enthalten.";
                    Btn2.Text = "Alle Fundstellen, die 'Accounting' enthalten in der Domain gulugulu.com aber nicht in der Subdomain marketing.gulugulu.com.";
                    Btn3.Text = "Alle Fundstellen, die in der Domain gulugulu.com und deren Subdomain marketing.gulugulu.com enthalten sind aber nicht das Wort 'accounting' enthalten.";
                    Btn4.Text = "Full-Disk-Encryption";
                    correctAnswer = 2;
                    break;
                case 43:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Passive Informationsbeschaffung (Reconnaissance, Discovery) umfasst das Sammeln von Informationen über welchen der folgenden Wege?";

                    Btn1.Text = "Social Engineering";
                    Btn2.Text = "Network Sniffing";
                    Btn3.Text = "Man-in-the-Middle Attack (MITM)";
                    Btn4.Text = "öffentlich zugängliche Quellen";
                    correctAnswer = 4;
                    break;
                case 44:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches Tool bereitet die Verbindung zwischen verschiedenen, gesammelten Informationen auf und stellt diese grafisch dar?";

                    Btn1.Text = "Cain & Abel";
                    Btn2.Text = "Metasploit";
                    Btn3.Text = "Maltego";
                    Btn4.Text = "WireShark";
                    correctAnswer = 3;
                    break;
                case 45:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Während der Informationsbeschaffungsphase entdeckst du diverse Word- und PDF-Dateien sowie Bilder. Du möchtest die Metadaten dieser Dateien auslesen, um diese zu analysieren. Welches Programm wirst du verwenden?";

                    Btn1.Text = "Metagoofil";
                    Btn2.Text = "Metasploit";
                    Btn3.Text = "Meterpreter";
                    Btn4.Text = "WireShark";
                    correctAnswer = 1;
                    break;
                case 46:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Das Sammeln von Informationen aus öffentlich zugänglichen Quellen ist auch bekannt als:";

                    Btn1.Text = "Human Intelligence";
                    Btn2.Text = "Social Intelligence";
                    Btn3.Text = "Real Intelligence";
                    Btn4.Text = "Open Source Intelligence";
                    correctAnswer = 4;
                    break;
                case 47:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Hendrik möchte im Rahmen eines Penetration Tests herausfinden, welche Domain-Namen, Plattformen und Webtechnologien von der Zielorganisation für ihre Server im Internet genutzt werden. Welche Suchmaschine kann ihm in dieser Hinsicht am effektivsten weiterhelfen?";

                    Btn1.Text = "Google";
                    Btn2.Text = "NetCraft";
                    Btn3.Text = "Shodan";
                    Btn4.Text = "GHDB";
                    correctAnswer = 2;
                    break;
                case 48:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Andrea sammelt im Rahmen eines Penetration Tests Informationen zu Mitarbeitern des Ziel-Unternehmens auf Social Media-Plattformen. Welchen der im folgenden genannten Hacking-Schritte kann sie mit den gesammelten Informationen unterstützen?";

                    Btn1.Text = "Password Cracking";
                    Btn2.Text = "Vulnerability Expliting (Schwachstellen ausnutzen)";
                    Btn3.Text = "Clearing Tracks (Spuren verwischen)";
                    Btn4.Text = "Man-in-the-Middle";
                    correctAnswer = 1;
                    break;
                case 49:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Informationen stellt Whois nicht bereit?";

                    Btn1.Text = "Email Adressen";
                    Btn2.Text = "Telefonnummern";
                    Btn3.Text = "Netzbereiche und deren Eigentümer";
                    Btn4.Text = "Betriebssystem Plattformen";
                    correctAnswer = 4;
                    break;
                case 50:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Über welchen Port kommuniziert DNS?";

                    Btn1.Text = "67 UDP";
                    Btn2.Text = "53 UDP und TCP";
                    Btn3.Text = "69 UDP";
                    Btn4.Text = "53 UDP";
                    correctAnswer = 2;
                    break;
                case 51:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches der folgenden Tools ermöglicht keine DNS-Namensauflösung?";

                    Btn1.Text = "host";
                    Btn2.Text = "resolve";
                    Btn3.Text = "dig";
                    Btn4.Text = "nslookup";
                    correctAnswer = 2;
                    break;
                case 52: // Quiz 6
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher Nmap-Befehl führt einen Xmas-Scan durch?";

                    Btn1.Text = "nmap -sA 192.168.1.254";
                    Btn2.Text = "nmap -sP 192.168.1.254";
                    Btn3.Text = "nmap -sX 192.168.1.254";
                    Btn4.Text = "nmap -sV 192.168.1.254";
                    correctAnswer = 3;
                    break;
                case 53:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welchen ICMP-Typ nutzt der Ping-Befehl für die Anfragen (Echo Requests)?";

                    Btn1.Text = "ICMP Typ 3 und 0";
                    Btn2.Text = "ICMP Typ 11";
                    Btn3.Text = "ICMP Typ 0";
                    Btn4.Text = "ICMP Typ 8";
                    correctAnswer = 4;
                    break;
                case 54:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "# nmap -sn 192.168.1.200-250 Der obige Nmap - Befehl führt welchen Scan - Typ aus ? ";

                    Btn1.Text = "Einen Ping-Scan.";
                    Btn2.Text = "Einen Trace-Sweep.";
                    Btn3.Text = "Eine Versionskennung.";
                    Btn4.Text = "Einen Standard-Portscan.";
                    correctAnswer = 1;
                    break;
                case 55:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches Programm ist nicht dafür geeignet, Banner Grabbing durchzuführen?";

                    Btn1.Text = "Telnet";
                    Btn2.Text = "Nmap";
                    Btn3.Text = "netstat";
                    Btn4.Text = "NetCat";
                    correctAnswer = 3;
                    break;
                case 56:
                    Pb1.Image = Properties.Resources.NmapScan;
                    LblQuestion.Text = "In Anbetracht des Portscan, welches Betriebssystem ist dahinter zu vermuten?";

                    Btn1.Text = "Windows XP";
                    Btn2.Text = "Windows 10";
                    Btn3.Text = "Windows 7";
                    Btn4.Text = "Widnows 2000 Server";
                    correctAnswer = 4;
                    break;
                case 57:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches der folgenden Tools ist nicht dazu geeignet, einen umfassenden Netzwerk-Scan durchzuführen?";

                    Btn1.Text = "Telnet";
                    Btn2.Text = "HiPing3";
                    Btn3.Text = "Nmap";
                    Btn4.Text = "Metasploit";
                    correctAnswer = 1;
                    break;
                case 58:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein Ethical Hacker namens Andreas versucht im Rahmen eines Penetration Tests, das Computersystem einer Bank zu kompromittieren. Zunächst muss er wissen, welches Betriebssystem die Zielcomputer verwenden, um weitere Angriffe zu planen. Welchen der folgenden Schritte wird er als nächstes ausführen?";

                    Btn1.Text = "IDL/IPID Scanning";
                    Btn2.Text = "Banner Grabbing";
                    Btn3.Text = "ÚDP Scanning";
                    Btn4.Text = "SSDP Scanning";
                    correctAnswer = 2;
                    break;
                case 59:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Jens ist Penetration Tester und wurde beauftragt, einen gut gesicherten Webserver zu scannen. Welche der folgenden Scan-Methoden hilft ihm dabei unentdeckt zu bleiben?";

                    Btn1.Text = "TCP-ACK-Scanning";
                    Btn2.Text = "SYN-Stealth-Scanning";
                    Btn3.Text = "IP Fragment Scanning";
                    Btn4.Text = "Inverse TCP Flag Scanning";
                    correctAnswer = 3;
                    break;
                case 60:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Das Architekturbüro Windschief verwendet als Netz für die Bürokommunikation ein Subnetz 192.168.1.64 mit der Subnetzmaske 255.255.255.192. Justus hat von einem Mitarbeiter des Büros die Information erhalten, dass die Server die Adressen 192.168.1.122-124 verwenden. Er möchte einen Scan durchführen und gibt den folgenden Befehl ein:nmap - sV - v - T4 192.168.1.64/28 Im Ergebnis kann er aber die genannten Server-Adressen nicht entdecken. Wo liegt der Fehler?";

                    Btn1.Text = "Das Netzwerk ist vermutlich inaktiv. Das Nmap-Kommando und die IP-Adresse sind korrekt.";
                    Btn2.Text = "Er Scannt 192.168.1.65 bis 192.168.1.178, da die Subnetze /28 sind.";
                    Btn3.Text = "Er muss die Netzwerkaddresse auf 192.168.1.0 mit derselben Netzwerkmaske setzen.";
                    Btn4.Text = "Vor der Angabe des Ziels muss er Nmap die Option --ip-address angeben.";
                    correctAnswer = 2;
                    break;
                case 61:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Das Aufbauen einer TCP-Session erfordert eine Sitzungsaushandlung namens 3-Way-Handshake. Welche Flags sind im dritten TCP-Segment gesetzt?";

                    Btn1.Text = "RST";
                    Btn2.Text = "Syn-ACK";
                    Btn3.Text = "SYN";
                    Btn4.Text = "ACK";
                    correctAnswer = 4;
                    break;
                case 62:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Manuela möchte einen ICMP-Scan auf einen Remote-Computer durchführen mit Hping3. Wie lautet die korrekte Syntax?";

                    Btn1.Text = "hping3 host.domain.com";
                    Btn2.Text = "hping3 -1 host.domain.com";
                    Btn3.Text = "hping 3-i host.domain.com";
                    Btn4.Text = "hping3 --set-icmp host.domain.com";
                    correctAnswer = 2;
                    break;
                case 63:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Nach einem Security-Alarm analysiert Gerd die IP-Adresse, von welcher der Angriff kam. Welche der im folgenden genannten Informationen sind am wenigsten relevant?";

                    Btn1.Text = "ARP";
                    Btn2.Text = "DNS";
                    Btn3.Text = "Whois";
                    Btn4.Text = "Geolocation";
                    correctAnswer = 1;
                    break;
                case 64: // Quiz 7
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Paul ist Ethical Hacker und wird als Security Consultant in einer mittelständischen Firma mit dem Review der wichtigsten Anwendungen beauftragt. Der verantwortliche Administrator Yusuf fragt ihn, welche Sicherheitsmechanismen er hinsichtlich DNS-Security empfehlen würde. Welche der im folgenden genannten Maßnahmen ist nicht dazu geeignet, die DNS-Sicherheit zu erhöhen?";

                    Btn1.Text = "DNS-Server-Hardening";
                    Btn2.Text = "DNS-Server und andere Dienste auf den selben System verwenden, um die Aufmerksamkeit abzulenken.";
                    Btn3.Text = "Split-Horizon";
                    Btn4.Text = "Zonen-Transfer beschränken";
                    correctAnswer = 2;
                    break;
                case 65:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "SNMP ist ein Protokoll, das zum Abfragen von Hosts und Netzwerk-Komponenten genutzt wird, um deren Status, Performance und andere Informationen zu ermitteln. Es handelt sich um eines der Lieblingsprotokolle von Hackern, die schon seit vielen Jahren via SNMP umfangreiche Informationen über Zielsysteme erlangen können. Welche Tatsache macht dies hauptsächlich möglich?";

                    Btn1.Text = "SNMP kann im Gegensatz zu Telnet einfach mit Hilfe eines Netzwerksniffers wie WireShark mitgelesen werden.";
                    Btn2.Text = "Die SNMP-Spezifikationen sind in RFC-Dokumenten veröffentlicht und können von jedermann analysiert und genutzt werden.";
                    Btn3.Text = "SNMP nutzt Comunity-Strings die zum einen einen in Klartext übertragen werden und zum anderen häufig standardisiert sind.";
                    Btn4.Text = "Die SNMP-Spezifikationen sind in CLI-Dokumenten veröffentlicht und können von jedermann analysiert und genutzt werden.";
                    correctAnswer = 3;
                    break;
                case 66:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein Unternehmen stellt mehrere Server mit Web-Anwendungen öffentlich bereit. Zusätzlich existiert ein Intranet für den internen Bereich, der durch eine Firewall geschützt ist. Welche Technik kann gegen Enumeration schützen?";

                    Btn1.Text = "Entfernen aller A-Records für den internen host.";
                    Btn2.Text = "Ablehnen aller ungültigen Emails die via SMTP empfangen werden.";
                    Btn3.Text = "Aktivieren von Null-Session-Pipes.";
                    Btn4.Text = "Zulassen von vollständigen Zonenfile-Transfers.";
                    correctAnswer = 1;
                    break;
                case 67:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Michelle ist zertifiziert als CEH und als Security-Analyst in einem größeren Unternehmen tätig. Ihr Kollege Harry vom ServiceDesk kommt auf Michelle zu und fragt sie, was es mit einem 'Null User' auf sich hat. Welche der folgenden Antworten kann sie ihm geben, um den Kontext eines Null Users zu beschreiben? ";

                    Btn1.Text = "Ein User der keine IT Kenntnisse hat.";
                    Btn2.Text = "Ein Account den der Admin gesperrt hat.";
                    Btn3.Text = "Ein Pseudo-Account, der für Sicherheitszwecke wird und keinerlei Rechte hat.";
                    Btn4.Text = "Ein Pseudo-Account, der weder einen Benutzernamen noch ein Passwort hat.";
                    correctAnswer = 4;
                    break;
                case 68:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was ist ein DNS AAAA Record?";

                    Btn1.Text = "Ein Authorization, Authentication and Auditing AddressRecord.";
                    Btn2.Text = "Ein Address Prefix Record.";
                    Btn3.Text = "Ein IPv6 Host Record.";
                    Btn4.Text = "Ein Address Database Record.";
                    correctAnswer = 3;
                    break;
                case 69:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein Netzwerk besteht aus verschiedenen Plattformen auf Windows- und Linux-Basis. Nach welchem Port sollte Noah im Nmap-Scan-Output achten, um zu bestimmen, ob ein Host File Sharing aktiviert hat?";

                    Btn1.Text = "161";
                    Btn2.Text = "445";
                    Btn3.Text = "1433";
                    Btn4.Text = "443";
                    correctAnswer = 2;
                    break;
                case 70:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Arya möchte mit nslookup eine DNS-Abfrage starten, um die autoritativen Nameserver für eine Zone zu ermitteln. Sie arbeitet im interaktiven Modus. Wie lautet der Befehl, um den Abfragetyp entsprechend zu ändern?";

                    Btn1.Text = "locate type=ns";
                    Btn2.Text = "set type=ns";
                    Btn3.Text = "request typ=ns";
                    Btn4.Text = "transfer type=ns";
                    correctAnswer = 2;
                    break;
                case 71:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was bedeutet AXFR?";

                    Btn1.Text = "Es handelt sich um ein SMTP-Kommando, mit dem vom Server Authentisierung angefordert wird.";
                    Btn2.Text = "AXFR ist ein P2P-Client zur SNMP-Enumeration.";
                    Btn3.Text = "AXFR ist ein asynchrones Verfahren zum Zeitabgleich im Rahmen von NTP.";
                    Btn4.Text = "Es handelt sich um einen DNS-Zonentransfer, bei dem alle Einträge einer Zone übermittelt werden.";
                    correctAnswer = 4;
                    break;
                case 72:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Rana ist Ethical Hacker und wurde mit dem Penetration Test eines Kunden-Netzwerks beauftragt. Nachdem Sie die ersten Schritte der Informationsbeschaffung durchgeführt hat, möchte Sie nun mit der Enumeration der Zielsysteme beginnen. Welches der folgenden Protokolle ist kein primäres Ziel für Enumeration?";

                    Btn1.Text = "FTP";
                    Btn2.Text = "SMTP";
                    Btn3.Text = "NTP";
                    Btn4.Text = "DNS";
                    correctAnswer = 1;
                    break;
                case 73:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches der folgenden Tools wird nicht für SMB- und NetBIOS-Enumeration verwendet?";

                    Btn1.Text = "nbtscan";
                    Btn2.Text = "nmap";
                    Btn3.Text = "onesixtyone";
                    Btn4.Text = "nbtstat";
                    correctAnswer = 3;
                    break;
                case 74: // Quiz 8
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Du wurdest von deinem Unternehmen beauftragt, ein technisches Security-Assessment eines Kundennetzwerks durchzuführen. Welche der folgenden Optionen ist der effektivste Weg, um Schwachstellen auf Windows-basierten Computer zu ermitteln?";

                    Btn1.Text = "Auf mitre.org nach den neuesten CVE-Findings recherchieren.";
                    Btn2.Text = "Ein Scanning-Tool wie Nessus verwenden.";
                    Btn3.Text = "Windows-Eigene-Tools wie den Microsoft Baseline Security Analyzer (MBSA) verwenden.";
                    Btn4.Text = "Ein Disk-Image einer frischen Windows-Installation erstellen und mit dem Zielsystem vergleichen.";
                    correctAnswer = 2;
                    break;
                case 75: 
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Eine neu entdeckte, noch nicht behobene Sicherheitslücke ist welche Art von Vulnerability?";

                    Btn1.Text = "Input Validation Error.";
                    Btn2.Text = "HTTP Header Injection Vulnerability.";
                    Btn3.Text = "0-Day Vulnerability.";
                    Btn4.Text = "SQLi Vulnerability.";
                    correctAnswer = 3;
                    break;
                case 76:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches der folgenden Programme ist nicht für das Vulnerability-Scanning geeignet?";

                    Btn1.Text = "Nexpose";
                    Btn2.Text = "Netstat";
                    Btn3.Text = "OpenVAS";
                    Btn4.Text = "Nessus";
                    correctAnswer = 2;
                    break;
                case 77:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Nina befindet sich in einem Vorstellungsgespräch als Security-Analystin. Herr Langschmidt, der anwesende Mitarbeiter der IT-Abteilung, fragt Nina nach dem Unterschied zwischen einem Vulnerability-Assessment und einem Penetration Test. Welche Antwort beschreibt den Unterschied am besten?";

                    Btn1.Text = "Vulnerability-Assessment ist ein anderes Wort für Penetration Test, Inhaltlich gibt es keine Unterschiede.";
                    Btn2.Text = "Vulnerability-Assessment werden regelmäßig intern durchgeführt, Penetration-Tests dagegen nur einmalig. Für einen Penetration-Test wird immer ein externer Consultant beauftragt.";
                    Btn3.Text = "Vulnerability-Assessments nutzen automatisierte Tools wie Nessus oder OpenVAS, während Penetration-Tests manuel durchgeführt werden.";
                    Btn4.Text = "Vulnerability-Assessments sind standardisiert und teils automatisiert während Penetration-Tests zielgerichteter und individueller ablaufen. Dabei geht ein Penetration-Test oft tiefer als ein Vulnerability-Assessment.";
                    correctAnswer = 4;
                    break;
                case 78:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was ist der erste Schritt im Vulnerability-Assessment-Prozess?";

                    Btn1.Text = "Erstellen einer Baseline.";
                    Btn2.Text = "Durchführen eines Risk-Assessments.";
                    Btn3.Text = "Durchführen einer Schwachstellenanalyse.";
                    Btn4.Text = "Monitoring laufender Prozesse.";
                    correctAnswer = 1;
                    break;
                case 79:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Aussage in Bezug auf Vulnerability-Scanner trifft zu?";

                    Btn1.Text = "Es sollte grundsätzlich nur ein Vulnerability-Scanner verwendet werden. Mehrere Produkte einzusetzen verfälscht das Ergebnis.";
                    Btn2.Text = "Ergebnisse eines Vulnerability-Scanners müssen vom Security-Verantwortlichen nur überprüftwerden, wenn die gefundene Schwachstelle für die IT-Umgebungder Organisation relevant ist.";
                    Btn3.Text = "Zu einem Penetration-Test gehören Vulnerability-Scanner obligatorisch dazu.";
                    Btn4.Text = "Vulnerability-Scanner werden nur im Rahmen von Vulnerability-Assessments eingesetzt. In Penetration-Tests werden die Schwachstellen durch den Penetration-Tester gesucht.";
                    correctAnswer = 2;
                    break;
                case 80:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Sie diskutieren mit Ihrem Auftraggeber den Rahmen eines Penetration Tests. Sie fragen ihn, ob er einen Remote-Scan oder eher einen Credential-Scan durchführen lassen möchte. Ihr Gegenüber fragt Sie, was er sich unter einem Credential-Scan vorstellen muss. Welche der folgenden Antworten trifft auf den Credential-Scan zu?";

                    Btn1.Text = "Ein Credential-Scan wird immer in Ergänzung zu einem Remote-Scan durchgeführt. Der Scan wird nach der Anmeldung eines Administrators am Scanner durchgeführt.";
                    Btn2.Text = "Es  handelt sich um einen speziellen Scan-Typ. Bei einem Credential-Scan geht es darum, möglichst viele Credentials, also Zugangsdaten und Form von Benutzernamen und Passwörtern zu ermitteln.";
                    Btn3.Text = "Bei einem Credential-Scan werden nur Anwendungen geprüft, die eine Anmeldung verlangen. Andere Systene werden nicht betrachtet.";
                    Btn4.Text = "Ein Credential-Scan steht im Gegensatz zu einem Remote-Scan und nutzt bereitgestellte Credentials, um einen Angreifer zu simulieren, der Zugriff auf interne Anmeldedaten hat.";
                    correctAnswer = 4;
                    break;
                case 81: // Quiz 9
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Amanda ist als Security-Analyst in einem Consulting-Gespräch über Zugangssicherheit. Der Systemadministrator des Unternehmens fragt sie, welche Zugriffsschutz-Mechanismen sie empfehlen würde. Amanda weist darauf hin, dass zunächst die Authentisierung erfolgt und dann der Zugriff zu den Ressourcen geregelt wird. Welches der folgenden Kriterien kann nicht für die Feststellung der Identität verwendet werden?";

                    Btn1.Text = "Etwas, das man hat.";
                    Btn2.Text = "Etwas, das man darf.";
                    Btn3.Text = "Etwas, das man weiß.";
                    Btn4.Text = "Etwas, das man ist.";
                    correctAnswer = 2;
                    break;
                case 82:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Methoden ist eine Zwei-Faktor-Authentisierung?";

                    Btn1.Text = "Ausweis, Badge";
                    Btn2.Text = "Retina-Scan, Fingerabdruck";
                    Btn3.Text = "Passwort, Ausweis";
                    Btn4.Text = "PIN, Passphrase";
                    correctAnswer = 3;
                    break;
                case 83:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Lina möchte im Rahmen eines Penetration Tests Passwörter identifizieren und cracken. Sie verbindet sich mit einem Switch und sorgt mit ARP-Flooding dafür, dass der Switch einen Fallback in den Hub-Modus durchführt. Anschließend startet sie einen ARP-Spoofing-Angriff zur Vorbereitung eines Man-in-the-Middle-Angriffs. Tatsächlich schafft sie es, die Kommunikation zwischen den beiden Opfersystemen über ihren Laptop auf Kali Linux-Basis umzulenken. Sie starten einen Netzwerk-Sniffer, um Passwörter im Netzwerk-Traffic zu erspähen. Welche Art des Passwort-Angriffs führt sie durch?";

                    Btn1.Text = "Passive-Online-Attack";
                    Btn2.Text = "Active-Online-Attack";
                    Btn3.Text = "Offline-Attack";
                    Btn4.Text = "Nicht elektronischer Angriff";
                    correctAnswer = 1;
                    break;
                case 84:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Aussage lässt sich aus dem folgenden LM-Hashwert ableiten? DEB5ABAD35B55019AAD35B51404EE";

                    Btn1.Text = "Es handelt sich um ein leeres Passwort.";
                    Btn2.Text = "Der Hashwert ist kein LM sondern ein NTLM-Hashwert.";
                    Btn3.Text = "Das Passwort besteht aus 14 Nullen.";
                    Btn4.Text = "Das Passwort ist weniger als acht Zeichen lang.";
                    correctAnswer = 4;
                    break;
                case 85:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "In welcher Reihenfolge werden bei Kerberos die Authentifizierungs- und Autorisierungskomponenten angesprochen?";

                    Btn1.Text = "Authentication Server - Ticket Granting Server - Ressource";
                    Btn2.Text = "Ressource - Authentication Server - Ticket Granting Server";
                    Btn3.Text = "Ticket Granting Server - Authentication Sever - Ressource";
                    Btn4.Text = "Authentication Server - Ressource - Ticket Granting Server";
                    correctAnswer = 1;
                    break;
                case 86:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches der folgenden Tools ist dazu geeignet, ein Kerberos Golden Ticket zu erstellen?";

                    Btn1.Text = "Medusa";
                    Btn2.Text = "Hydra";
                    Btn3.Text = "Mimikatz";
                    Btn4.Text = "Ncrack";
                    correctAnswer = 3;
                    break;
                case 87:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Du möchtest im Rahmen eines Penetration Tests die Credentials von Benutzern eines Linux-Servers cracken. Es gelingt dir, administrativen Zugriff auf eine Shell des Zielservers zu erlangen. Wo sind die Hashwerte der Benutzer-Passwörter gespeichert?";

                    Btn1.Text = "/etc/passwd";
                    Btn2.Text = "/etc/shadow";
                    Btn3.Text = "/etc/passwords";
                    Btn4.Text = "/etc/pam.d";
                    correctAnswer = 2;
                    break;
                case 88:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Du möchtest sicherstellen, dass deine Passwörter gut geschützt sind gegen Rainbow-Table-Angriffe. Welche der folgenden Maßnahmen kann dich dabei nicht unterstützen?";

                    Btn1.Text = "Ein langes schwer zu erratendes Passwort.";
                    Btn2.Text = "Der Einsatz-SALT.";
                    Btn3.Text = "Verwendung von NTLM statt LM.";
                    Btn4.Text = "Sperren des Kontos nach 5 fehlerhaften Anmeldeversuchen.";
                    correctAnswer = 3;
                    break;
                case 89:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Jules arbeitet als Ethical Hacker und ist damit beauftragt, einen Stand-Alone-Windows-Computer zu hacken. Welches Programm kann er nutzen, um die SAM-Datenbank auszulesen und damit die Benutzer und Passwörter des Systems zu ermitteln?";

                    Btn1.Text = "FGDump";
                    Btn2.Text = "Medusa";
                    Btn3.Text = "Ncrack";
                    Btn4.Text = "Hydra";
                    correctAnswer = 1;
                    break;
                case 90:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "In welchem Angriffsszenario ist es für den Angreifer nicht erforderlich, das Kennwort des Benutzers zu kennen?";

                    Btn1.Text = "Brute-Force-Attack";
                    Btn2.Text = "Pass-the-Hash";
                    Btn3.Text = "Dictionary Attack";
                    Btn4.Text = "Rainbow-Tables";
                    correctAnswer = 2;
                    break;
                case 91: // Quiz 10
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Durch eine Schwachstelle auf einem FTP-Serverdienst hast du Zugriff als root auf einem zentralen Server erlangt. Was solltest du im nächsten Schritt unternehmen ? ";

                    Btn1.Text = "Einen User-Account mit entsprechenden Rechtern erstellen.";
                    Btn2.Text = "Alle Daten des Servers herunterladen.";
                    Btn3.Text = "IP-Tables deaktivieren.";
                    Btn4.Text = "Einen Portscan mit Nmap durchführen.";
                    correctAnswer = 1;
                    break;
                case 92:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher der folgenden Maßnahmen gehört nicht zur Phase der Post-Exploitation?";

                    Btn1.Text = "Backdoor bereitstellen.";
                    Btn2.Text = "Horizontale Privilegieneskalation.";
                    Btn3.Text = "Vertikale Privilegieneskalation.";
                    Btn4.Text = "Passive Discovery.";
                    correctAnswer = 4;
                    break;
                case 93:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche dieser Shells existiert nicht?";

                    Btn1.Text = "Xtreme Shell (X-Shell)";
                    Btn2.Text = "PowerShell";
                    Btn3.Text = "Bourne-Again-Shell (Bash)";
                    Btn4.Text = "C-Shell";
                    correctAnswer = 1;
                    break;
                case 94:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie lautet der Befehl der notwendig ist, um Ncat als Server auf Port 80 bereitzustellen?";

                    Btn1.Text = "ncat --server 192.1680.100 80";
                    Btn2.Text = "nc <eigene IP> 80";
                    Btn3.Text = "nc -ip 80";
                    Btn4.Text = "ncserver 192.168.0.100";
                    correctAnswer = 3;
                    break;
                case 95:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches dieser Tools stellt ein umfassendes Framework für Post-Exploitation bereit?";

                    Btn1.Text = "Nmap";
                    Btn2.Text = "Nessus";
                    Btn3.Text = "Maltego";
                    Btn4.Text = "Empire";
                    correctAnswer = 4;
                    break;
                case 96:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Fabian, ein Black-Hat-Hacker, hat es geschafft, eine Meterpreter-Session auf einem der E-Corp-Systeme zu erlangen. Er prüft seine SID und stellt fest, dass er ist mit den Rechten eines normalen Domänenbenutzers auf dem System unterwegs ist. Was muss Fabian tun, um einen vollen Administrationszugriff zu erlangen?";

                    Btn1.Text = "Er muss den Virenscanner deaktivieren.";
                    Btn2.Text = "Er benötigt physikalischen Zugriff auf das System.";
                    Btn3.Text = "Er muss seine Privilegien eskalieren.";
                    Btn4.Text = "Er versucht mit Hilfe eines Denial-of-Service Angriff, das System in die Knie zu zwingen und nutzt dies aus, um Exploits auf das geschwächte System anzuwenden.";
                    correctAnswer = 3;
                    break;
                case 97:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Nina hat eine Reverse Shell im Kontext eines Systembenutzers auf dem Opfersystem erlangt. Sie versucht, weitere Benutzer auf dem System zu identifizieren, in der Hoffnung, dass Sie mit einem dieser Benutzer auf einem anderen System im Netzwerk Zugriff erlangt. Wie wird dieser Prozess genannt?";

                    Btn1.Text = "Vertikale Privileigen-Eskalation.";
                    Btn2.Text = "Netuwerk-Privilegian-Eskalation";
                    Btn3.Text = "System-Privilegien-Eskalation";
                    Btn4.Text = "Horizontale-Privilegien-Eskalation";
                    correctAnswer = 4;
                    break;
                case 98:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche der folgenden Aussagen trifft zu auf Bind- und Reverse-Shells?";

                    Btn1.Text = "Eine BIND-Shell wird zum Opfer-System zum System des Angreifers aufgebaut, während eine Reverse-Shell auf eine eingehende Verbindungsanforderung wartet.";
                    Btn2.Text = "Eine BIND-Shell wird auf dem Opfer-System erstellt, während eine Reverse-Shell auf dem Angreifer-Rechner bereitgestellt wird.";
                    Btn3.Text = "Sowohl BIND, als auch Reverse-Shells werden auf dem Opfer-System erstellt, sie unterscheiden sich nur in der Art des Verbindungsaufbaus.";
                    Btn4.Text = "Eine Reverse-Shell wartet auf dem Opfer-System auf einen Verbindungsaufbau, während die Bind-Shell das Oper-System und den Angreifer verbindet.";
                    correctAnswer = 4;
                    break;
                case 99:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was wird unter einer Root-Shell verstanden?";

                    Btn1.Text = "Eine Root-Shell kann nur auf einem Linux/Unix-System existieren und berschreibt eine Shell mit Root-Rechten.";
                    Btn2.Text = "Eine Root-Shell bezeichnet eine Shell im Kontext des Administrators - egal ob unter Linux oder Windows.";
                    Btn3.Text = "Eine Root-Shell wird von einem Administrator unter Windows oder Linux erstellt.";
                    Btn4.Text = "Eine Root-Shell bezeichnet eine Shell auf der obersten Ebene des Betriebssystems.";
                    correctAnswer = 2;
                    break;
                case 100:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Benedikt kann sich über eine Schwachstelle in einem Netzwerk-Dienst eine Shell auf dem Opfersystem verschaffen. Er installiert eine Backdoor für zukünftige Zugriffe. Wie wird dieser Schritt im Rahmen des Hacking-Prozesses genannt?";

                    Btn1.Text = "Gaining Access";
                    Btn2.Text = "Reconnaissance";
                    Btn3.Text = "Maintaining Access";
                    Btn4.Text = "Exploiting";
                    correctAnswer = 3;
                    break;
                case 101: // Quiz_11
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie wird die Art von Malware-Analyse genannt, bei der das Programm nicht ausgeführt wird?";

                    Btn1.Text = "Dynamische Malware-Analyse";
                    Btn2.Text = "Sensible Malware-Analyse";
                    Btn3.Text = "Statische Malware-Analyse";
                    Btn4.Text = "Passive Malware-Analyse";
                    correctAnswer = 3;
                    break;
                case 102:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Werkzeug ist es bei der statischen Codeanalyse möglich, den Quellcode wiederherzustellen?";

                    Btn1.Text = "Decompiler";
                    Btn2.Text = "Sandbox";
                    Btn3.Text = "Netzwerksniffer";
                    Btn4.Text = "Assembler";
                    correctAnswer = 1;
                    break;
                case 103:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches der folgenden Tools ist in der Lage, eine Programmdatei sehr einfach einer ersten Analyse zu unterziehen um ggf. Indikatoren einer Schadsoftware zu identifizieren?";

                    Btn1.Text = "UPX";
                    Btn2.Text = "ASPack";
                    Btn3.Text = "pestudio";
                    Btn4.Text = "Sigverif";
                    correctAnswer = 3;
                    break;
                case 104:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein System verhält sich seltsam: Die Festplatten-LED leuchtet non-stop, die Lüfter drehen hoch und irgendwie hast du das Gefühl dein ganzes System ist langsamer als sonst. Du befürchtest das Schlimmste und startest einen Scan mit deinem installierten Virenscanner. Doch dieser kann keine Schadsoftware identifizieren. Welchen Vorgehen könntest du als nächstes verfolgen ? ";

                    Btn1.Text = "Virencheck mit Rescue-Disc";
                    Btn2.Text = "System muss neu aufgesetzt werden.";
                    Btn3.Text = "Keine weiteren Aktionen erforderlich.";
                    Btn4.Text = "Nmap-Scan";
                    correctAnswer = 1;
                    break;
                case 105:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wie kannst du die Funktion und die korrekte Einstellung deines Virenscanners überprüfen?";

                    Btn1.Text = "EICAR-Testdatei";
                    Btn2.Text = "CARO-Updater";
                    Btn3.Text = "AVIAR-Testdatei";
                    Btn4.Text = "Sigverif-Scan";
                    correctAnswer = 1;
                    break;
                case 106:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was versteht man unter einem 'geforkten' Prozess?";

                    Btn1.Text = "Ein Prozess, der sich als ein anderer tarnt.";
                    Btn2.Text = "Ein Prozess, der sich immer wieder selber startet.";
                    Btn3.Text = "Ein Prozess, der andere Prozesse killt.";
                    Btn4.Text = "Ein Prozess, der von einem anderen Prozess aufgerufen wird.";
                    correctAnswer = 4;
                    break;
                case 107:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Du hast das Gefühl im Hintergrund läuft ohne dein Zutun ein unerwünschtes Programm. Ein umfangreicher Virenscan mit Hilfe einer Rescue - Disc hat leider keine Schadsoftware identifizieren können. Was überprüfst du als nächstes ? ";

                    Btn1.Text = "Ob eine DVD im Laufwerk ist.";
                    Btn2.Text = "Wieviel Speicherplatz noch zur Verfügung steht.";
                    Btn3.Text = "Laufende Prozesse mit dem Taskmanager.";
                    Btn4.Text = "Der Verlauf des Browsers.";
                    correctAnswer = 3;
                    break;
                case 108:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Über welche Datei kann die lokale DNS-Auflösung manipuliert werden?";

                    Btn1.Text = "Benutzer/Appdata/Local/DNS";
                    Btn2.Text = "Windows/System32/Drivers/etc/host";
                    Btn3.Text = "Windows/hosts";
                    Btn4.Text = "Windows/System32/config/resolve";
                    correctAnswer = 2;
                    break;
                case 109:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Befehl kannst du über die Windows Command Line die TCP-Netzwerkzugriffe überprüfen und den dazugehörenden Prozess anzeigen lassen? ";

                    Btn1.Text = "systeminfo --tcp";
                    Btn2.Text = "netstat -tlpn";
                    Btn3.Text = "netstat -nabp tcp";
                    Btn4.Text = "netsh -all";
                    correctAnswer = 3;
                    break;
                case 110:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Eine Freundin von dir beschwert sich, dass auf ihrem System nach jedem Neustart ein unerwünschtes Programm gestartet wird. Sie fühlt sich sehr gestört davon, und fragt nach deinem Rat, um dies abzustellen. Was schaust du dir als erstes an ? (Wähle die beste Antwort)";

                    Btn1.Text = "Windows-Update-Manager";
                    Btn2.Text = "BIOS-Einstellungen";
                    Btn3.Text = "Autostart-Einträge";
                    Btn4.Text = "Gebundene Netzwerk-Ports";
                    correctAnswer = 3;
                    break;
                case 111:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Unter welchem Registrierungsschlüssel befinden sich die Einstellungen, die für das gesamte System gelten?";

                    Btn1.Text = "HKEY_CURRENT_USER";
                    Btn2.Text = "HKEY_LOCALE_MACHINE";
                    Btn3.Text = "HKEY_CLASSES_ROOT";
                    Btn4.Text = "HKEY_CURRENT_CONFIG";
                    correctAnswer = 2;
                    break;
                case 112:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Windows-Bordmittel können Einträge in der Registrierungsdatenbank kontrolliert werden? ";

                    Btn1.Text = "Registrierungseditor (regedit.exe)";
                    Btn2.Text = "Task-Manager";
                    Btn3.Text = "Computer-Verwaltung";
                    Btn4.Text = "Netzwerkstatistiken";
                    correctAnswer = 1;
                    break;
                case 113:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Worin besteht die besondere Gefahr, sollte ein Angreifer einen Treiber manipulieren?";

                    Btn1.Text = "Der Angreifer kann Dokumente ausdrucken.";
                    Btn2.Text = "Der Angreifer hat automatisch Zugriff auf andere Systeme im Netzwerk.";
                    Btn3.Text = "Der Angreifer hat eine MITM-Position.";
                    Btn4.Text = "Der Angreifer hat ggf. kernelnahen Zugriff auf Systemfunktionen.";
                    correctAnswer = 4;
                    break;
                case 114:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was verbirgt sich hinter der Abkürzung PUP im Bezug auf Malware?";

                    Btn1.Text = "Potentialy Unwanted Program";
                    Btn2.Text = "Pathetic Use of Potential";
                    Btn3.Text = "Priority Unsecure Program";
                    Btn4.Text = "Process under Pressure";
                    correctAnswer = 1;
                    break;
                case 115:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Tool kannst du unter Windows die Signaturen der Systemdateien prüfen?";

                    Btn1.Text = "EICAR-Testfile";
                    Btn2.Text = "Avast Free Antivirus";
                    Btn3.Text = "Dateisignaturverifzierung (sigverif.exe";
                    Btn4.Text = "pestudio";
                    correctAnswer = 3;
                    break;
                case 116:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem Mittel kann die Datei-Integrität geprüft, und damit sichergestellt werden, dass die Datei nicht manipuliert wurde?";

                    Btn1.Text = "Prüfsummen-Check";
                    Btn2.Text = "Netzwerk-Scan";
                    Btn3.Text = "Defragmentierung";
                    Btn4.Text = "Überprüfung mit Virus-Total";
                    correctAnswer = 1;
                    break;
                case 117:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was verstehen wir unter 'False - Positive ?'";

                    Btn1.Text = "Zustand einer richtig erkannten Bedrohung.";
                    Btn2.Text = "Zustand einer Bedrohung die nicht identifiziert werden konnte.";
                    Btn3.Text = "Zustand der fälschlicherweise als Bedrohung erkannt wurde.";
                    Btn4.Text = "Zustand eines virenfreien Systems.";
                    correctAnswer = 3;
                    break;
                case 118:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Mit welchem dieser Tools kann die Systemintegrität geprüft werden?";

                    Btn1.Text = "Sandboxie";
                    Btn2.Text = "Tripwire";
                    Btn3.Text = "Any-Run";
                    Btn4.Text = "sigverif";
                    correctAnswer = 2;
                    break;
                case 119:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welches System kannst du als Perimeter-Schutz für Wechselmedien isoliert vom Unternehmensnetzwerk aufsetzen und mit entsprechender Analysesoftware bestücken? (Wähle die beste Antwort)";

                    Btn1.Text = "Sandbox-System";
                    Btn2.Text = "Sheep-Dip-System";
                    Btn3.Text = "Debugging-System";
                    Btn4.Text = "Rescue-Disc-System";
                    correctAnswer = 1;
                    break;
                case 120:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was bedeutet Sandbox?";

                    Btn1.Text = "Ein vom Rest des Systems abgeschotteter Bereich, in dem Änderungen keine Auswirkungen auf das laufende System haben. Hier können verdächtige Dateien und Programme ausgeführt werden, um diese zu analysieren.";
                    Btn2.Text = "Hier können Malware-Dateien (Samples) hochgeladen und online analysiert werden ohne das die Datei auf dem eigenen System gestartet werden muss.";
                    Btn3.Text = "Es handelt sich hier bei um ein isoliertes System mit Analyse-Software auf welchem Malware analysiert werden kann.";
                    Btn4.Text = "Eine Sandbox ist ein speziell gehärtetes System innerhalb des Unternehmensnetzwerks, welches als Proxy Emails abfängt und analyisert.";
                    correctAnswer = 1;
                    break;
                case 121: // Quiz 12
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Jens möchte geheime Daten an eine Konkurrenzfirma senden. Dazu plant er, die Geheiminformationen in einer normalen Nachricht zu verstecken und geht nach dem Prinzip: 'Security through Obscurity' vor. Welche Technik setzt er ein?";

                    Btn1.Text = "Symmetrische Verschlüsselung";
                    Btn2.Text = "Asymmetrische Verschlüsselung";
                    Btn3.Text = "AES256";
                    Btn4.Text = "Steganografie";
                    correctAnswer = 4;
                    break;
                case 122:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Ein Weg, um eine Multi-Level-Security-Infrastruktur zu umgehen und Daten nach außen zu transportieren, ist ...";

                    Btn1.Text = "Ein Covert Channel";
                    Btn2.Text = "Asymmetrisches Routing";
                    Btn3.Text = "Denial-of-Service-Angriff";
                    Btn4.Text = "Bypassing";
                    correctAnswer = 1;
                    break;
                case 123:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Wird eine Datei in einer anderen Datei versteckt, so wird die resultierende Datei mit welchem der folgenden Begriffe bezeichnet?";

                    Btn1.Text = "Thesaurus";
                    Btn2.Text = "Stegosaurus";
                    Btn3.Text = "Steganogramm";
                    Btn4.Text = "Covered Cypher";
                    correctAnswer = 3;
                    break;
                case 124:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welche Steganographie-Technik nutzt ein Bild, eine Zeichnung oder einen manipulierten Text, um Daten zu verstecken?";

                    Btn1.Text = "Steganalyse";
                    Btn2.Text = "Semagramm";
                    Btn3.Text = "Open Code";
                    Btn4.Text = "Technische Steganografie";
                    correctAnswer = 2;
                    break;
                case 125:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Was verstehen wir unter 'Grille Cipher'?";

                    Btn1.Text = "Eine Rastertechnik, bei der mittels einer Schablone die Textstellen bzw. die Zeichen der geheimen und versteckten Nachricht sichtbar werden.";
                    Btn2.Text = "Eine Verschlüsselungstechnik, die darauf basiert, Geheimnachrichten in unsinnigen Text zu verstecken.";
                    Btn3.Text = "Eine Steganografie-Technik, die auf Längs- und Querlinien basiert und dadurch einen versteckten Text sichtbar macht.";
                    Btn4.Text = "Eine computerbasierte Technik, um Daten in einer Datei nach einem bestimmten Muster  zu speichern.";
                    correctAnswer = 1;
                    break;
                case 126:
                    Pb1.Image = Properties.Resources.EthicalHackerQuiz;
                    LblQuestion.Text = "Welcher Algorithmus wird häufig bei der computerbasierten Steganographie eingesetzt?";

                    Btn1.Text = "LSB";
                    Btn2.Text = "High Order Bits";
                    Btn3.Text = "Morsecode";
                    Btn4.Text = "Null Cypher";
                    correctAnswer = 1;
                    break;

            }
        }




        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnKontakt_Click(object sender, EventArgs e)
        {
            string toAddress = "itsupport@mdagehrmann.de";
            string subject = "Kontaktaufnahme: Quiz Zero Trust";
            string body = "Sehr geehrter Herr Gehrmann,%0D%0A " +
                "ich komme heute auf Sie zu mit einer bestimmten Anfrage. " +
                "%0D%0A" +
                "%0D%0A" +
                "%0D%0A" +
                "Mit freundlichen Grüßen";

            MailMessage mail = new MailMessage();
            mail.To.Add(toAddress);
            mail.Subject = subject;
            mail.Body = body;

            try
            {
                System.Diagnostics.Process.Start("mailto:" + toAddress + "?subject="
                + subject + "&body=" + body);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler beim Öffnen der E-Mail: " + ex.Message);
            }
        }
    }
}
