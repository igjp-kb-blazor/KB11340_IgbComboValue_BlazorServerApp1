const getCombo = (containerElement) => {
    return new Promise((resolve, reject) => {
        // igc-combo探してみる。
        const combo = containerElement.querySelector('igc-combo');
        // 見つかったらそれを返す
        if (combo !== null) { resolve(combo); }
        // 見つからなかったら見つかるまで10ミリ秒ごとにigc-gridを再検索する。
        else {
            let counter = 0;
            const timerId = setInterval(() => {
                counter++;
                const combo = containerElement.querySelector('igc-grid');
                console.log(combo);
                if (combo !== null) {
                    clearInterval(timerId);
                    resolve(combo);
                }
                else if (counter > (5000 / 10)) {
                    clearInterval(timerId);
                    reject();
                }
            }, 10)
        }
    });
};

export const getComboValuesScript = async (containerElement) => {
    const igcCombo = await getCombo(containerElement);
    return igcCombo.value;
}