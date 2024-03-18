if (typeof $$epiforms !== 'undefined') {
    $$epiforms(document).ready(function myfunction() {
        console.log('listen to event');
        $$epiforms(".EPiServerForms").on("formsNavigationNextStep formsNavigationPrevStep formsSetupCompleted formsReset formsStartSubmitting formsSubmitted formsSubmittedError formsNavigateToStep formsStepValidating",
            function (event, param1, param2) {
                debugger;
                console.log($$epiforms(this).get(0), event);
            });
    });
}