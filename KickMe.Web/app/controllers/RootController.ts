module app {
	'use strict';

	class RootController {
		constructor(private $modal: ng.ui.bootstrap.IModalService) {
			//
		}

		createProject() {
			this.$modal.open({

				templateUrl: '/templates/project-form.html',
				controller: 'ProjectFormController',
				controllerAs: 'vm'
			});
		}
	}

	angular.module('app').controller('RootController', RootController);
}
