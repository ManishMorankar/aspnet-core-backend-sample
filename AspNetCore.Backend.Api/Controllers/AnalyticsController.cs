﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Backend.Api.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
    public class AnalyticsController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
           var data = Content("{\"visits\":{\"count\":4.332,\"logins\":830,\"sign_out_pct\":0.5,\"rate_pct\":4.5},\"performance\":{\"sdk\":{\"this_period_pct\":60,\"last_period_pct\":30},\"integration\":{\"this_period_pct\":40,\"last_period_pct\":55}},\"server\":{\"1\":{\"pct\":60,\"temp\":37,\"frequency\":3.3},\"2\":{\"pct\":54,\"temp\":31,\"frequency\":3.3}},\"revenue\":[{\"label\":\"SMX\",\"data\":59},{\"label\":\"Direct\",\"data\":32},{\"label\":\"Networks\",\"data\":48}],\"mainChart\":[[[0,0],[1,0.156],[2,0.676],[3,1.1960000000000002],[4,1.7160000000000002],[5,2.236],[6,2.3920000000000003],[7,2.5480000000000005],[8,2.5839874358475767],[9,2.5029874358475768],[10,2.2329874358475768],[11,1.9629874358475767],[12,1.6929874358475767],[13,1.4229874358475767],[14,1.1529874358475767],[15,0.8829874358475767],[16,0.6129874358475766],[17,0.5319874358475767],[18,0.45098743584757667],[19,0.4163628287687911],[20,0.4531128287687911],[21,0.575612828768791],[22,0.698112828768791],[23,0.8206128287687909],[24,0.9431128287687909],[25,1.065612828768791],[26,1.188112828768791],[27,1.310612828768791],[28,1.433112828768791],[29,1.5556128287687911],[30,1.6781128287687912],[31,1.8006128287687913],[32,1.9231128287687913],[33,2.045612828768791],[34,2.168112828768791],[35,2.2906128287687912],[36,2.4131128287687913],[37,2.4498628287687914],[38,2.4866128287687914],[39,2.487088606548258],[40,2.421088606548258],[41,2.2010886065482578],[42,1.9810886065482578],[43,1.7610886065482578],[44,1.5410886065482579],[45,1.3210886065482579],[46,1.101088606548258],[47,0.8810886065482579],[48,0.8150886065482579],[49,0.754744529957805],[50,0.7894245299578051],[51,0.9050245299578051],[52,1.0206245299578052],[53,1.136224529957805],[54,1.251824529957805],[55,1.367424529957805],[56,1.4830245299578049],[57,1.5986245299578048],[58,1.7142245299578047],[59,1.8298245299578046],[60,1.9454245299578046],[61,2.0610245299578045],[62,2.1766245299578046],[63,2.292224529957805],[64,2.407824529957805],[65,2.523424529957805],[66,2.6390245299578052],[67,2.7546245299578054],[68,2.789304529957805],[69,2.796140836064743],[70,2.721140836064743],[71,2.471140836064743],[72,2.221140836064743],[73,1.9711408360647429],[74,1.7211408360647429],[75,1.4711408360647429],[76,1.2211408360647429],[77,0.9711408360647429],[78,0.8961408360647429],[79,0.821140836064743],[80,0.777368780004726],[81,0.804368780004726],[82,0.894368780004726],[83,0.9843687800047259],[84,1.074368780004726],[85,1.164368780004726],[86,1.254368780004726],[87,1.3443687800047261],[88,1.4343687800047262],[89,1.5243687800047263]],[[0,0],[1,0.20400000000000001],[2,0.8840000000000001],[3,1.564],[4,2.244],[5,2.9240000000000004],[6,3.1280000000000006],[7,3.3320000000000007],[8,3.414169051562861],[9,3.3031690515628607],[10,2.9331690515628606],[11,2.5631690515628605],[12,2.1931690515628603],[13,1.8231690515628602],[14,1.4531690515628601],[15,1.08316905156286],[16,0.71316905156286],[17,0.60216905156286],[18,0.4914196120207356],[19,0.5418496120207356],[20,0.7099496120207356],[21,0.8780496120207355],[22,1.0461496120207354],[23,1.2142496120207353],[24,1.3823496120207353],[25,1.5504496120207352],[26,1.718549612020735],[27,1.886649612020735],[28,2.054749612020735],[29,2.222849612020735],[30,2.390949612020735],[31,2.559049612020735],[32,2.727149612020735],[33,2.8952496120207347],[34,2.9456796120207347],[35,2.952748734557632],[36,2.8597487345576322],[37,2.549748734557632],[38,2.239748734557632],[39,1.929748734557632],[40,1.619748734557632],[41,1.309748734557632],[42,0.9997487345576319],[43,0.6897487345576319],[44,0.5967487345576319],[45,0.5037487345576319],[46,0.46700065536263524],[47,0.5150006553626353],[48,0.6750006553626353],[49,0.8350006553626353],[50,0.9950006553626354],[51,1.1550006553626355],[52,1.3150006553626357],[53,1.4750006553626358],[54,1.635000655362636],[55,1.795000655362636],[56,1.9550006553626362],[57,2.1150006553626364],[58,2.2750006553626365],[59,2.4350006553626367],[60,2.595000655362637],[61,2.755000655362637],[62,2.803000655362637],[63,2.851000655362637],[64,2.860031095991114],[65,2.7850310959911138],[66,2.5350310959911138],[67,2.2850310959911138],[68,2.0350310959911138],[69,1.7850310959911138],[70,1.5350310959911138],[71,1.2850310959911138],[72,1.0350310959911138],[73,0.9600310959911138],[74,0.8850310959911138],[75,0.8616950351890166],[76,0.9224450351890165],[77,1.1249450351890165],[78,1.3274450351890166],[79,1.5299450351890167],[80,1.7324450351890168],[81,1.934945035189017],[82,2.137445035189017],[83,2.339945035189017],[84,2.5424450351890173],[85,2.7449450351890174],[86,2.9474450351890176],[87,3.1499450351890177],[88,3.352445035189018],[89,3.413195035189018]],[[0,0],[1,0.162],[2,0.7020000000000001],[3,1.242],[4,1.782],[5,2.322],[6,2.862],[7,3.402],[8,3.564],[9,3.726],[10,3.7919156971721693],[11,3.719915697172169],[12,3.479915697172169],[13,3.2399156971721688],[14,2.9999156971721685],[15,2.7599156971721683],[16,2.519915697172168],[17,2.279915697172168],[18,2.0399156971721677],[19,1.7999156971721677],[20,1.5599156971721677],[21,1.3199156971721677],[22,1.2479156971721677],[23,1.1759156971721676],[24,1.1247193643455318],[25,1.1465893643455318],[26,1.2194893643455318],[27,1.2923893643455318],[28,1.3652893643455317],[29,1.4381893643455317],[30,1.5110893643455316],[31,1.5839893643455316],[32,1.6568893643455316],[33,1.7297893643455315],[34,1.8026893643455315],[35,1.8755893643455315],[36,1.9484893643455314],[37,2.0213893643455316],[38,2.094289364345532],[39,2.167189364345532],[40,2.240089364345532],[41,2.3129893643455324],[42,2.3858893643455326],[43,2.4587893643455327],[44,2.531689364345533],[45,2.604589364345533],[46,2.6774893643455333],[47,2.7503893643455335],[48,2.8232893643455337],[49,2.896189364345534],[50,2.969089364345534],[51,3.0419893643455342],[52,3.1148893643455344],[53,3.1877893643455346],[54,3.260689364345535],[55,3.2825593643455346],[56,3.3044293643455345],[57,3.319637748020533],[58,3.2596377480205327],[59,3.0596377480205326],[60,2.8596377480205324],[61,2.659637748020532],[62,2.459637748020532],[63,2.259637748020532],[64,2.0596377480205317],[65,1.8596377480205317],[66,1.6596377480205318],[67,1.4596377480205318],[68,1.2596377480205319],[69,1.1996377480205318],[70,1.162357712058923],[71,1.182637712058923],[72,1.2502377120589232],[73,1.3178377120589233],[74,1.3854377120589234],[75,1.4530377120589235],[76,1.5206377120589236],[77,1.5882377120589237],[78,1.6558377120589238],[79,1.723437712058924],[80,1.791037712058924],[81,1.8586377120589241],[82,1.9262377120589242],[83,1.9938377120589243],[84,2.0614377120589245],[85,2.1290377120589246],[86,2.1966377120589247],[87,2.2642377120589248],[88,2.331837712058925],[89,2.399437712058925]]]}", "application/json");
           return await Task.FromResult(data);
        }
    }
}