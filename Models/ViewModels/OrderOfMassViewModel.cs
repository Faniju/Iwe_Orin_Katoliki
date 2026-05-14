using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using YorubaCatholicHymn.Data;
using YorubaCatholicHymn.Models;

public class OrderOfMassViewModel : BindableObject
{
    // Preface
    private readonly ObservableCollection<Preface> allPrefaces;
    public ObservableCollection<Preface> Prefaces { get; }
    private Preface selectedPreface;
    public Preface SelectedPreface
    {
        get => selectedPreface;
        set
        {
            selectedPreface = value;
            OnPropertyChanged();
            // For selectable modes, rendered preface follows picker selection.
            if (value != null)
            {
                EffectivePreface = value;
            }
        }
    }

    // Eucharistic Prayers
    public ObservableCollection<EucharisticPrayer> EucharisticPrayers { get; }
    private EucharisticPrayer selectedPrayer;
    public EucharisticPrayer SelectedPrayer
    {
        get => selectedPrayer;
        set
        {
            selectedPrayer = value;
            OnPropertyChanged();
            // Show Communicantes only for Prayer I
            IsCommunicantesSectionVisible = selectedPrayer?.Number == "I";
            OnPropertyChanged(nameof(IsCommunicantesSectionVisible));
            // Close any communicantes picker popup whenever prayer changes
            IsCommunicantesPickerVisible = false;
            OnPropertyChanged(nameof(IsCommunicantesPickerVisible));
            // If Prayer I, select the Usual Form communicantes by default; otherwise clear
            if (selectedPrayer?.Number == "I")
            {
                SelectedCommunicantes = EucharisticPrayerData.GetDefaultCommunicantes();
            }
            else
            {
                SelectedCommunicantes = null;
            }
            ApplyPrefaceRules();
        }
    }

    // Communicantes
    private Communicantes selectedCommunicantes;
    public Communicantes SelectedCommunicantes
    {
        get => selectedCommunicantes;
        set { selectedCommunicantes = value; OnPropertyChanged(); }
    }
    private bool isGloriaVisible;
    public bool IsGloriaVisible
    {
        get => isGloriaVisible;
        set
        {
            isGloriaVisible = value;
            OnPropertyChanged();
            GloriaButtonIcon = isGloriaVisible ? "▼ Choice" : "▲ Choice";
            // E70D = ChevronDown, E70E = ChevronUp in Segoe MDL2
            OnPropertyChanged(nameof(GloriaButtonIcon));
        }
    }

    public string GloriaButtonIcon { get; set; } = "▲ Choice"; // default down arrow

    public ICommand ToggleGloriaCommand => new Command(() =>
    {
        IsGloriaVisible = !IsGloriaVisible;
    });

    // Confession visibility flags
    public bool IsConfession1Visible { get; set; } = true;
    public bool IsConfession2Visible { get; set; }
    public bool IsConfession3Visible { get; set; }

    public string confessionButtonText;
    public string ConfessionButtonText
    {
        get => confessionButtonText;
        set { confessionButtonText = value; OnPropertyChanged(); }
    }
    public  int confessionIndex = 1;

    public ICommand ToggleConfessionCommand => new Command(() =>
    {
        // Cycle index: 1 → 2 → 3 → back to 1
        confessionIndex = (confessionIndex % 3) + 1;

        // Update visibility
        IsConfession1Visible = confessionIndex == 1;
        IsConfession2Visible = confessionIndex == 2;
        IsConfession3Visible = confessionIndex == 3;

        OnPropertyChanged(nameof(IsConfession1Visible));
        OnPropertyChanged(nameof(IsConfession2Visible));
        OnPropertyChanged(nameof(IsConfession3Visible));

        // Update button text
        UpdateButtonText();
    });

    private void UpdateButtonText()
    {
        // Arrow: down for 1 & 2, up for 3
        string arrow = confessionIndex == 3 ? "▼" : "▼";
        ConfessionButtonText = $"{arrow} Choice {confessionIndex}";
    }

    // I Believe
    private int iBelieveIndex = 1; // start at 1

    public bool IsIBelieve1Visible { get; set; } = true;
    public bool IsIBelieve2Visible { get; set; }
    public bool IsIBelieveHidden { get; set; }

    private string iBelieveButtonText;
    public string IBelieveButtonText
    {
        get => iBelieveButtonText;
        set { iBelieveButtonText = value; OnPropertyChanged(); }
    }

    public ICommand ToggleIBelieveCommand => new Command(() =>
    {
        // Cycle: 1 → 2 → hidden → back to 1
        iBelieveIndex = (iBelieveIndex % 3) + 1;

        IsIBelieve1Visible = iBelieveIndex == 1;
        IsIBelieve2Visible = iBelieveIndex == 2;
        IsIBelieveHidden = iBelieveIndex == 3;

        OnPropertyChanged(nameof(IsIBelieve1Visible));
        OnPropertyChanged(nameof(IsIBelieve2Visible));
        OnPropertyChanged(nameof(IsIBelieveHidden));

        UpdateIBelieveButtonText();
    });

    private void UpdateIBelieveButtonText()
    {
        if (iBelieveIndex == 1)
            IBelieveButtonText = "▼ Choice";
        else if (iBelieveIndex == 2)
            IBelieveButtonText = "▼ Choice";
        else
            IBelieveButtonText = "▲ Choice";
    }
    // Visibility flags
    public bool IsPrefacePickerVisible { get; set; }
    public bool IsPrefaceIconVisible { get; set; } = true;
    public bool IsEucharistVisible { get; set; }
    public bool IsPrefaceSectionVisible { get; set; } = true;
    public bool IsCommunicantesSectionVisible { get; set; }
    public bool IsCommunicantesPickerVisible { get; set; }
    private Preface effectivePreface;
    public Preface EffectivePreface
    {
        get => effectivePreface;
        set { effectivePreface = value; OnPropertyChanged(); }
    }
    // Commands
    public ICommand TogglePrefaceCommand => new Command(async() =>
    {
        if (!IsPrefaceIconVisible)
        {
            return;
        }
        if (Prefaces.Count == 0 || Shell.Current?.CurrentPage == null)
        {
            return;
        }
        // Popup list immediately; user picks by liturgical season.
        var selectedSeason = await Shell.Current.CurrentPage.DisplayActionSheetAsync(
            "Select Preface Season",
            "Cancel",
            null,
            Prefaces.Select(p => p.Season).ToArray());
        if (string.IsNullOrWhiteSpace(selectedSeason) || selectedSeason == "Cancel")
        {
            return;
        }
        var match = Prefaces.FirstOrDefault(p => p.Season == selectedSeason);
        if (match != null)
        {
            SelectedPreface = match;
        }
    });

    public ICommand ToggleEucharistCommand => new Command(async() =>
    {
        if (EucharisticPrayers.Count == 0 || Shell.Current?.CurrentPage == null)
        {
            return;
        }
        // Build option labels that include the season/title and a short snippet (first non-empty line)
        var options = EucharisticPrayers
            .Select(p =>
            {
                var label = string.IsNullOrWhiteSpace(p.Season) ? p.Title : p.Season;
                // Prayer XI has no snippet
                if (string.Equals(p.Number, "XI", System.StringComparison.OrdinalIgnoreCase))
                    return label;
                // For prayers V and VI prefer the second non-empty line when the first is a comment
                bool preferSecondLine = string.Equals(p.Number, "V", System.StringComparison.OrdinalIgnoreCase)
                                        || string.Equals(p.Number, "VI", System.StringComparison.OrdinalIgnoreCase);
                var snippet = GetFirstLineSnippet(p.Text, 100, preferSecondLine);
                return string.IsNullOrWhiteSpace(snippet) ? label : $"{label} — {snippet}";
            })
            .ToList();

        var selectedLabel = await Shell.Current.CurrentPage.DisplayActionSheetAsync(
           "Select Eucharistic Prayer Season",
           "Cancel",
           null,
           options.ToArray());
    if (string.IsNullOrWhiteSpace(selectedLabel) || selectedLabel == "Cancel")
    {
            return;
        }
        var index = options.IndexOf(selectedLabel);
        if (index >= 0 && index < EucharisticPrayers.Count)
        {
            SelectedPrayer = EucharisticPrayers[index];
        }
    });

    // Helper: return first non-empty trimmed line and truncate to maxLength.
    // If preferSecondNonEmptyLine is true, use the second non-empty line when available.
    private static string GetFirstLineSnippet(string text, int maxLength = 80, bool preferSecondNonEmptyLine = false)
    {
        if (string.IsNullOrWhiteSpace(text))
            return string.Empty;
        var normalized = text.Replace("\r\n", "\n").Replace("\r", "\n");
        var lines = normalized.Split('\n');
        var tagRegex = new System.Text.RegularExpressions.Regex(@"\[/?(?:red|i|b)\]", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.Compiled);

        var nonEmptyLines = new System.Collections.Generic.List<string>();
        foreach (var line in lines)
        {
            var withoutTags = tagRegex.Replace(line, string.Empty);
            var trimmed = withoutTags.Trim();
            if (string.IsNullOrEmpty(trimmed))
                continue;
            // Skip lines that look like comment markers
            if (trimmed.StartsWith("[") || trimmed.StartsWith("(") || trimmed.StartsWith("--"))
                continue;
            nonEmptyLines.Add(trimmed);
        }

        if (nonEmptyLines.Count == 0)
            return string.Empty;

        var chosen = nonEmptyLines[0];
        if (preferSecondNonEmptyLine && nonEmptyLines.Count >= 2)
            chosen = nonEmptyLines[1];

        if (chosen.Length <= maxLength) return chosen;
        var cut = chosen.Substring(0, maxLength).TrimEnd();
        return cut + "...";
    }

    public ICommand ToggleCommunicantesCommand => new Command(async() =>
    {
        if (!IsCommunicantesSectionVisible)
        {
            return;
        }
        var list = SelectedPrayer?.CommunicantesList;
        if (list == null || list.Count == 0 || Shell.Current?.CurrentPage == null)
        {
            return;
        }
        var selectedSeason = await Shell.Current.CurrentPage.DisplayActionSheetAsync(
            "Select Communicantes Season",
            "Cancel",
            null,
            list.Select(c => c.Season).ToArray());
        if (string.IsNullOrWhiteSpace(selectedSeason) || selectedSeason == "Cancel")
        {
            return;
        }
        var match = list.FirstOrDefault(c => c.Season == selectedSeason);
        if (match != null)
        {
            SelectedCommunicantes = match;
        }
    });



    // Helper method to update prefaces based on selected prayer
    private void ApplyPrefaceRules()
    {
        var prayer = SelectedPrayer;
        if (prayer == null) return;

        var number = (prayer.Number ?? string.Empty).Trim().ToUpperInvariant();

        Prefaces.Clear();
        EffectivePreface = null;
        SelectedPreface = null;

        // Reset defaults
        IsPrefaceSectionVisible = true;
        IsPrefaceIconVisible = true;
        // Do NOT reset IsCommunicantesSectionVisible here — let the setter handle Prayer I

        switch (number)
        {
            case "I":
                // General prefaces + communicantes visible
                IsCommunicantesSectionVisible = true;
                foreach (var p in allPrefaces.Where(p => string.IsNullOrWhiteSpace(p.PrayerNumber)))
                    Prefaces.Add(p);
                SelectedPreface = Prefaces.FirstOrDefault();
                EffectivePreface = SelectedPreface;
                break;

            case "III":
                // General prefaces only
                foreach (var p in allPrefaces.Where(p => string.IsNullOrWhiteSpace(p.PrayerNumber)))
                    Prefaces.Add(p);
                SelectedPreface = Prefaces.FirstOrDefault();
                EffectivePreface = SelectedPreface;
                break;

            case "II":
            case "V":
            case "VI":
                // Own preface first, then general
                // Try to use the prayer's OwnPreface if set; otherwise look it up in allPrefaces
                var own = prayer.OwnPreface ?? allPrefaces
                    .FirstOrDefault(p => (p.PrayerNumber ?? string.Empty).Trim().ToUpperInvariant() == number
                                         && !string.IsNullOrWhiteSpace(p.Title));
                if (own != null)
                    Prefaces.Add(own);

                var general2 = allPrefaces.Where(p => string.IsNullOrWhiteSpace(p.PrayerNumber)).ToList();
                foreach (var p in general2)
                    Prefaces.Add(p);

                SelectedPreface = Prefaces.FirstOrDefault(); // own preface if present, otherwise first general
                EffectivePreface = SelectedPreface;
                break;

            case "IV":
            case "VII":
            case "VIII":
            case "IX":
            case "X":
                // Fixed own preface only
                IsPrefaceIconVisible = false;
                var fixedPreface = prayer.OwnPreface ??
                    allPrefaces.FirstOrDefault(p => (p.PrayerNumber ?? "").Trim().ToUpperInvariant() == number);
                EffectivePreface = fixedPreface;
                break;

            case "XI":
                // Hide everything
                IsPrefaceSectionVisible = false;
                IsPrefaceIconVisible = false;
                IsCommunicantesSectionVisible = false;
                break;

            default:
                // Fallback → general only
                foreach (var p in allPrefaces.Where(p => string.IsNullOrWhiteSpace(p.PrayerNumber)))
                    Prefaces.Add(p);
                SelectedPreface = Prefaces.FirstOrDefault();
                EffectivePreface = SelectedPreface;
                break;
        }

        OnPropertyChanged(nameof(IsPrefaceSectionVisible));
        OnPropertyChanged(nameof(IsPrefaceIconVisible));
        OnPropertyChanged(nameof(IsCommunicantesSectionVisible));
        OnPropertyChanged(nameof(EffectivePreface));
    }





    public OrderOfMassViewModel()
    {
        // Initialize collections first
        allPrefaces = new ObservableCollection<Preface>(PrefaceData.GetPrefaces());
        Prefaces = new ObservableCollection<Preface>(allPrefaces);
        EucharisticPrayers = new ObservableCollection<EucharisticPrayer>(EucharisticPrayerData.GetPrayers());
        SelectedPreface = Prefaces.Count > 0 ? Prefaces[0] : null;

        // Set selected prayer after Prefaces is initialized
        SelectedPrayer = EucharisticPrayers.Count > 0 ? EucharisticPrayers[0] : null;

        // No extra filtered prefacing needed here — Prefaces already initialized from allPrefaces.
        // Initialize button text correctly
        UpdateButtonText();
        UpdateIBelieveButtonText();
    }
}
