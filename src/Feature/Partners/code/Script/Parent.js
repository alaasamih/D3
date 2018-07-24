function getPartners(letter, contextSite) {
  $.get("Url.Action('GetPartnersList','Partners')?letter=" + letter, function (data) {
    $("#divPartners").html(data);

  });