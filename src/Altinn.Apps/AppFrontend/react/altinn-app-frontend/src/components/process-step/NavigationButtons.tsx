/* eslint-disable no-nested-ternary */
/* eslint-disable max-len */
import * as React from 'react';
import { AltinnButton } from 'altinn-shared/components';
import { Grid, makeStyles } from '@material-ui/core';
import { useDispatch, useSelector } from 'react-redux';
import { IRuntimeState, INavigationConfig, ILayoutNavigation } from 'src/types';
import classNames from 'classnames';
import { getTextFromAppOrDefault } from 'src/utils/textResource';
import { FormLayoutActions } from 'src/features/form/layout/formLayoutSlice';

const useStyles = makeStyles({
  root: {
    paddingTop: '2.4em',
  },
  backButton: {
    marginRight: '1.2em',
  },
});

export interface INavigationButtons {
  id: string;
  showBackButton: boolean;
  textResourceBindings: any;
  triggers?: string[];
}

export function NavigationButtons(props: INavigationButtons) {
  const classes = useStyles();
  const dispatch = useDispatch();
  const [disableBack, setDisableBack] = React.useState<boolean>(false);
  const [disableNext, setDisableNext] = React.useState<boolean>(false);
  const currentView = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.currentView);
  const orderedLayoutKeys = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.layoutOrder);
  const returnToView = useSelector((state: IRuntimeState) => state.formLayout.uiConfig.returnToView);
  const textResources = useSelector((state: IRuntimeState) => state.textResources.resources);
  const language = useSelector((state: IRuntimeState) => state.language.language);
  const { next, previous } = useSelector(
    (state: IRuntimeState) => getNavigationConfigForCurrentView(
      state.formLayout.uiConfig.navigationConfig,
      state.formLayout.uiConfig.currentView,
    ),
  );

  const nextTextKey = returnToView ? 'form_filler.back_to_summary' : props.textResourceBindings?.next || 'next';
  const backTextKey = props.textResourceBindings?.back || 'back';

  React.useEffect(() => {
    const currentViewIndex = orderedLayoutKeys?.indexOf(currentView);
    setDisableBack(!!returnToView || (!previous && currentViewIndex === 0));
    setDisableNext(!returnToView && !next && currentViewIndex === orderedLayoutKeys.length - 1);
  }, [currentView, orderedLayoutKeys]);

  const onClickPrevious = () => {
    const goToView = previous || orderedLayoutKeys[orderedLayoutKeys.indexOf(currentView) - 1];
    if (goToView) {
      dispatch(FormLayoutActions.updateCurrentView({ newView: goToView }));
    }
  };

  const OnClickNext = () => {
    const goToView = returnToView || next || orderedLayoutKeys[orderedLayoutKeys.indexOf(currentView) + 1];
    const runPageValidations = !returnToView && props.triggers && (props.triggers.indexOf('validatePage') > -1);
    const runAllValidations = returnToView || (props.triggers && (props.triggers.indexOf('validateAllPages') > -1));
    const validations = runAllValidations ? 'allPages' : (runPageValidations ? 'page' : null);
    if (goToView) {
      dispatch(FormLayoutActions.updateCurrentView({ newView: goToView, runValidations: validations }));
    }
  };

  return (
    <Grid
      container={true}
      justify='space-between'
      className={classes.root}
    >
      <Grid item={true} xs={10}>
        {!disableBack && props.showBackButton &&
          <AltinnButton
            btnText={getTextFromAppOrDefault(backTextKey, textResources, language, null, true)}
            onClickFunction={onClickPrevious}
            disabled={disableBack}
            className={classNames(classes.backButton)}
          />
        }
        {!disableNext &&
          <AltinnButton
            btnText={getTextFromAppOrDefault(nextTextKey, textResources, language, null, true)}
            onClickFunction={OnClickNext}
            disabled={disableNext}
          />
        }
      </Grid>
    </Grid>
  );
}

function getNavigationConfigForCurrentView(
  navigationConfig: INavigationConfig,
  currentView: string,
): ILayoutNavigation {
  if (navigationConfig && navigationConfig[currentView]) {
    return navigationConfig[currentView];
  }
  return {};
}
