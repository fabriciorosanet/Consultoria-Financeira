using System.ComponentModel.DataAnnotations;
using LandingPage.Data;
using LandingPage.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

public class IndexModel : PageModel
{
    private readonly AppDbContext _db;

    public IndexModel(AppDbContext db)
    {
        _db = db;
    }

    [BindProperty]
    public LeadInput Form { get; set; } = new();

    public string? SuccessMessage { get; set; }

    public void OnGet() { }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
            return Page();

        var lead = new Lead
        {
            Nome = Form.Nome.Trim(),
            Email = Form.Email.Trim(),
            Telefone = string.IsNullOrWhiteSpace(Form.Telefone) ? null : Form.Telefone.Trim(),
            Mensagem = string.IsNullOrWhiteSpace(Form.Mensagem) ? null : Form.Mensagem.Trim(),
            AceiteLGPD = Form.AceiteLGPD,
            Origem = Request.Headers["Referer"].ToString()
        };

        _db.Leads.Add(lead);
        await _db.SaveChangesAsync();

        ModelState.Clear();
        Form = new LeadInput();
        SuccessMessage = "Recebemos sua mensagem! Em breve entraremos em contato.";
        return Page();
    }

    public class LeadInput
    {
        [Display(Name = "Nome"), Required, StringLength(120)]
        public string Nome { get; set; } = string.Empty;

        [Display(Name = "E-mail"), Required, EmailAddress, StringLength(200)]
        public string Email { get; set; } = string.Empty;

        [Display(Name = "Telefone"), Phone, StringLength(30)]
        public string? Telefone { get; set; }

        [Display(Name = "Mensagem"), StringLength(2000)]
        public string? Mensagem { get; set; }

        [Display(Name = "Consentimento LGPD"), Required(ErrorMessage = "É necessário autorizar o uso dos dados.")]
        public bool AceiteLGPD { get; set; }
    }
}
