function convertToShortDate(datestring) {
    const shortDate = new Date(datestring).toLocaleDateString('tr-Tr'); 
}
function convertFirstLetterToUpperCase(text) {
    text = text.toString();
    const convertedText = text.charAt(0).toUpperCase() + text.slice(1).toLowerCase();
    return convertedText;
}

// kategori eklerken true ve falseun ilk harflerini büyük yazmak, ve Oluşturulma tarihini sadece tarih yazılmasını istedik. 